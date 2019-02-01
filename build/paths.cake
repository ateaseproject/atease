#load "./parameters.cake"
#load "./version.cake"
using System.Collections.Generic;
using System.Linq;

public class BuildPaths
{
    public BuildFiles Files { get; private set; }
    public BuildDirectories Directories { get; private set; }

    public static BuildPaths GetPaths(ICakeContext context, AppInfo appInfo, string configuration)
    {
        var buildDirectories = GetBuildDirectories(context);
        List<FilePath> testAssemblies = new List<FilePath>();

        foreach(var testDir in buildDirectories.TestDirs)
        {
            var adr = $"{testDir.ToString()}/**/bin/{configuration}/{appInfo.TargetFramework}/*.test.dll";
            var files =  context.GetFiles(adr);
            if (files != null)
            testAssemblies.AddRange(files);
        }
        var projectsToPack = new List<FilePath>
        {
            buildDirectories.SrcRootDir.CombineWithFilePath($"{appInfo.AppName}/{appInfo.AppName}.csproj"),
        };

        var buildFiles = new BuildFiles(
            buildDirectories.RootDir.CombineWithFilePath($"{appInfo.AppName}.sln"),
            buildDirectories.TestResultsDir.CombineWithFilePath("OpenCover.xml"),
            buildDirectories.RootDir.CombineWithFilePath("ReleaseNotes.md"),
            buildDirectories.ArtifactsDir.CombineWithFilePath("ReleaseNotes.md"),
            buildDirectories.ArtifactsDir.CombineWithFilePath("DupOutpuFinder.xml"),
            projectsToPack,
            testAssemblies);


        

        return new BuildPaths
        {
            Files = buildFiles,
            Directories = buildDirectories
        };
    }

    public static BuildDirectories GetBuildDirectories(ICakeContext context)
    {
        var rootDir = context.MakeAbsolute((DirectoryPath)context.Directory("../"));
        var artifactsDir = rootDir.Combine("artifacts");
        var testResultsDir = artifactsDir.Combine("Test-Results");
        var testResultsCoverReportDir = testResultsDir.Combine("Test-Results-Cover-Report");
        var srcRootDir =  rootDir.Combine("src");

        var testsRootDir = rootDir.Combine("tests");
        var specsRootDir = rootDir.Combine("specs");
        var nuspecRootDir = artifactsDir.Combine("nuspec");
        var nugetRootDir = artifactsDir.Combine("nuget");



        var testDirs = new []{
                                testsRootDir,
                                specsRootDir,
                            };
        var toClean = new[] {
                                artifactsDir,
                                testResultsDir,
                                nuspecRootDir,
                            };

      
        return new BuildDirectories(rootDir,
                                    srcRootDir,
                                    testsRootDir,
                                    specsRootDir,
                                    artifactsDir,
                                    nuspecRootDir,
                                    nugetRootDir,
                                    testResultsDir,
                                    testResultsCoverReportDir,
                                    testDirs,
                                    toClean);
    }
}

public class BuildFiles
{
    public FilePath Solution { get; private set; }
    public FilePath TestCoverageOutput { get; set;}
    public FilePath AllReleaseNotes { get; private set; }
    public FilePath CurrentReleaseNotes { get; private set; }
    public FilePath DupeFinderOutput { get; private set; }
    public ICollection<FilePath> ProjectsToPack { get; private set; }
    public ICollection<FilePath> TestAssemblies { get; private set; }

    public BuildFiles(FilePath solution,
                      FilePath testCoverageOutput,
                      FilePath allReleaseNotes,
                      FilePath currentReleaseNote,
                      FilePath dupeFinderOutput,
                      ICollection<FilePath> projectToPack,
                      ICollection<FilePath> testAssemblies)
    {
        Solution = solution;
        TestAssemblies = testAssemblies;
        TestCoverageOutput = testCoverageOutput;
        AllReleaseNotes = allReleaseNotes;
        CurrentReleaseNotes = currentReleaseNote;
        DupeFinderOutput = dupeFinderOutput;
        ProjectsToPack = projectToPack;
    }
}

public class BuildDirectories
{
    public DirectoryPath RootDir { get; private set; }
    public DirectoryPath SrcRootDir { get; private set; }
    public DirectoryPath TestsRootDir { get; private set; }
    public DirectoryPath SpecsRootDir { get; private set; }
    public DirectoryPath ArtifactsDir { get; private set; }
    public DirectoryPath NuspecRootDir { get; private set; }
    public DirectoryPath NugetRootDir { get; private set; }    
    public DirectoryPath TestResultsDir { get; private set; }
    public DirectoryPath TestResultsCoverReportDir{ get; private set; }
    public ICollection<DirectoryPath> TestDirs { get; private set; }
    public ICollection<DirectoryPath> ToClean { get; private set; }

    public BuildDirectories(
        DirectoryPath rootDir,
        DirectoryPath srcRootDir,
        DirectoryPath testsRootDir,
        DirectoryPath specsRootDir,
        DirectoryPath artifactsDir,
        DirectoryPath nuspecRootDir,
        DirectoryPath nugetRootDir,
        DirectoryPath testResultsDir,
        DirectoryPath testResultsCoverReportDir,
        ICollection<DirectoryPath> testDirs,
        ICollection<DirectoryPath> toClean)
    {
        RootDir = rootDir;
        SrcRootDir = srcRootDir;
        TestsRootDir = testsRootDir;
        SpecsRootDir = specsRootDir;
        ArtifactsDir = artifactsDir;
        NuspecRootDir = nuspecRootDir;
        NugetRootDir = nugetRootDir;
        TestDirs = testDirs;
        ToClean = toClean;
        TestResultsDir = testResultsDir;
        TestResultsCoverReportDir = testResultsCoverReportDir;
    }
}

public class BuildPackages
{
    public ICollection<FilePath> Packages { get; private set; }

    public BuildPackages(ICollection<FilePath> packages)
    {
        Packages = packages;
    }

    public static BuildPackages GetPackages(BuildPaths paths, BuildVersion version)
    {
        var packageName = "Achehre.Framework." + version.SemVersion + ".nupkg";
        var packages = new [] 
        {
            paths.Directories.NugetRootDir.CombineWithFilePath(packageName),
        };

        return new BuildPackages(packages);    
    }
}