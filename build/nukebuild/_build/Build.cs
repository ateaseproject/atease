using System;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Execution;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

//[CheckBuildProjectConfigurations]
[ShutdownDotNetAfterServerBuild]
class Build : NukeBuild
{
    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [GitRepository] readonly GitRepository GitRepository;


    readonly string[] NugetProjects = {"AtEase"};

    [Solution] readonly Solution Solution;

    [Parameter] string NugetApiKey = "";
    [Parameter] string NugetApiUrl = $"https://api.nuget.org/v3/index.json"; //default

    AbsolutePath SourceDirectory => RootDirectory / "src";

    AbsolutePath TestsDirectory => RootDirectory / "tests";
    AbsolutePath ArtifactsDirectory => RootDirectory / "artifacts";
    AbsolutePath NugetDirectory => ArtifactsDirectory / "nuget";

    AbsolutePath NugetConfig => RootDirectory / "build" /  "nuget.config";

    public static int Main() =>
        Execute<Build>(
        x => x.PackageRestore,
        x => x.PackageCompile,
        x => x.PackageUnitTests,
        x => x.PackagePack,
                       x => x.PackagePush);

    #region Package

    Target PackageClean => _ => _
                               .Before(PackageRestore)
                               .Executes(() =>
                                {
                                    EnsureCleanDirectory(ArtifactsDirectory);
                                });

    Target PackageRestore => _ => _
                                 .DependsOn(PackageClean)
                                 .Executes(() =>
                                  {
                                      DotNetRestore(s => s
                                                        .SetProjectFile(Solution)
                                                        .EnableNoCache()
                                                        .SetConfigFile(NugetConfig));
                                  });

    Target PackageCompile => _ => _
                                 .DependsOn(PackageRestore)
                                 .Executes(() =>
                                  {
                                      DotNetBuild(s => s
                                                      .SetProjectFile(Solution)
                                                      .SetConfiguration(Configuration)
                                                       //                                               .SetAssemblyVersion(GitVersion.AssemblySemVer)
                                                       //                                               .SetFileVersion(GitVersion.AssemblySemFileVer)
                                                       //                                               .SetInformationalVersion(GitVersion.InformationalVersion)
                                                      .EnableNoRestore());
                                  });

    Target PackageUnitTests => _ => _
                                   .DependsOn(PackageCompile)
                                   .Executes(() =>
                                    {
                                        TestsDirectory.GlobFiles("*/*.Test.csproj")
#pragma warning disable CS0618
                                            .NotEmpty()
#pragma warning restore CS0618
                                            .ForEach(x =>
                                                       {
                                                           DotNetTest(s => s
                                                                          .SetFramework("net5.0")
                                                                          .SetProjectFile(x)
                                                                          .SetConfiguration(Configuration.Release));
                                                       });
                                    });


    Target PackagePack => _ => _
                              .DependsOn(PackageUnitTests)
                              .Executes(() =>
                               {
                                   foreach (var nugetProject in NugetProjects)
                                   {
                                       DotNetPack(s => s
                                                      .SetProject(Solution.GetProject(nugetProject))
                                                      .SetOutputDirectory(NugetDirectory)
                                                      .SetConfiguration(Configuration.Release));
                                   }
                               });

    Target PackagePush => _ => _
                              .DependsOn(PackagePack)
                              .Requires(() => NugetApiUrl)
                              .Requires(() => NugetApiKey)
                              //.Requires(() => Configuration.Equals(Configuration.Release))
                              .Executes(() =>
                               {
                                   NugetDirectory.GlobFiles("*.nupkg")
#pragma warning disable CS0618
                                       .NotEmpty()
#pragma warning restore CS0618
                                       .ForEach(x =>
                                                  {
                                                      try
                                                      {
                                                          DotNetNuGetPush(s => s
                                                                              .SetTargetPath(x)
                                                                              .SetSource(NugetApiUrl)
                                                                              .SetApiKey(NugetApiKey)
                                                          );
                                                      }
                                                      catch (Exception e)
                                                      {
                                                          Logger.Error("Error on pushing package");
                                                          Logger.Error(x.ToString());
                                                          Logger.Error(e);
                                                      }
                                                  });
                               });

    #endregion
}