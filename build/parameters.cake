#load "./paths.cake"
#load "./version.cake"
#load "./credentials.cake"


public class AppInfo
{
    public string TargetFramework { get; private set; }
    public string TargetFrameworkFull { get; private set; }
    public string AppName { get; private set; }
    public string GitHubRepositoryName { get; private set; }
    public static AppInfo GetAppInfo()
    {
       return new AppInfo()
       {
            AppName = "AtEase",
            GitHubRepositoryName  = "AtEase",
            TargetFramework = "netcoreapp2.2",
            TargetFrameworkFull = "netstandard2.0",
       };
    }

    public override string ToString()
    {
        return $"AppName: {AppName}\nGitHubRepositoryName: {GitHubRepositoryName}\nTargetFramework: {TargetFramework}\nTargetFrameworkFull: {TargetFrameworkFull}";
    }  
}

public class BuildParameters
{
    public string Target { get; private set; }
    public string Configuration { get; private set; }

    public bool IsRunningOnWindows { get; private set; }
    public bool IsRunningOnAppVeyor { get; private set; }


    public bool SkipOpenCover { get; set; }
    public bool IsMaster { get; private set; }
    public bool IsDev { get; private set; }
    public bool IsLocalBuild { get; private set; }
    public bool IsTagged { get; private set; }
    public bool IsPullRequest { get; private set; }
    public bool ShouldPublish => !IsLocalBuild && IsMaster && IsTagged && !IsPullRequest;  
    
    public ReleaseNotes ReleaseNotes { get; private set; }
    public BuildGitHub GitHub { get; private set; }            
    public BuildNuGet NuGet { get; private set; }            
    public BuildVersion Version { get; private set; }
    public BuildPaths Paths { get; private set; }
    public BuildPackages Packages { get; set; }  
    public AppInfo AppInfo { get; set; }


    public static BuildParameters GetParameters(ICakeContext context)
    {
        if (context == null)
        {
            throw new ArgumentNullException("context");
        }

        var appInfo = AppInfo.GetAppInfo();
        var buildSystem = context.BuildSystem();
        var isLocalBuild = buildSystem.IsLocalBuild;
        var configuration = context.Argument("configuration", "Debug");
        var version =  BuildVersion.Calculate(context, isLocalBuild); 
        BuildPaths paths = BuildPaths.GetPaths(context, appInfo, configuration);  
            
        ReleaseNotes  releaseNotes  = null;
        var releaseNotesPath = new FilePath($@"{paths.Directories.RootDir}ReleaseNotes.md");
        if (context.FileExists(releaseNotesPath))
        {
            releaseNotes = context.ParseReleaseNotes(releaseNotesPath);
        }

       
        return new BuildParameters {
            Target = context.Argument("target", "Default"),
            Configuration = configuration,
            SkipOpenCover = context.Argument<bool>("SkipOpenCover", false),
            IsLocalBuild = isLocalBuild,
            IsMaster = StringComparer.OrdinalIgnoreCase.Equals("master", buildSystem.AppVeyor.Environment.Repository.Branch),
            IsDev = StringComparer.OrdinalIgnoreCase.Equals("dev", buildSystem.AppVeyor.Environment.Repository.Branch),
            IsTagged = IsBuildTagged(buildSystem),
            IsPullRequest = IsPullRequestBuild(buildSystem),
            AppInfo = appInfo,
            GitHub = BuildGitHub.GetWithCredentials(context, "AChehre", appInfo.GitHubRepositoryName),
            NuGet = BuildNuGet.GetWithCredentials(context),
            Version = version,
            Paths = paths,
            Packages = BuildPackages.GetPackages(paths, version),
            ReleaseNotes = releaseNotes
        };
    }

    private static bool IsBuildTagged(BuildSystem buildSystem)
    {
        return buildSystem.AppVeyor.Environment.Repository.Tag.IsTag
            && !string.IsNullOrWhiteSpace(buildSystem.AppVeyor.Environment.Repository.Tag.Name);
    }

    private static bool IsPullRequestBuild(BuildSystem buildSystem)
    {
        return buildSystem.AppVeyor.Environment.PullRequest.IsPullRequest;
    }
}