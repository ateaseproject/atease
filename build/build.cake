#tool "nuget:?package=GitVersion.CommandLine"
#load "./parameters.cake"
// #tool "nuget:?package=OpenCover"
// #tool "nuget:?package=ReportGenerator"



using System.Text.RegularExpressions;

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////
BuildParameters parameters = BuildParameters.GetParameters(Context);

///////////////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
///////////////////////////////////////////////////////////////////////////////

Setup(ctx =>
{
   	parameters = BuildParameters.GetParameters(Context);
   	Information("AppInfo========================================");
	Information(parameters.AppInfo.ToString());
	Information("Nuget========================================");
	Information(parameters.NuGet.ToString());
	Information("GitHub========================================");
	Information(parameters.GitHub.ToString());		 	


	Information("Parameters========================================");
   	Information($"SemVersion: {parameters.Version.SemVersion}");
   	Information($"IsLocalBuild: {parameters.IsLocalBuild}");    
   	Information($"IsTagged: {parameters.IsTagged}");
   	Information($"IsPullRequest: {parameters.IsPullRequest}");
   	Information($"Target: {parameters.Target}");   
	
   Information("Running tasks...");
});

Teardown(ctx =>
{
   // Executed AFTER the last task.
   Information("Finished running tasks.");
});


///////////////////////////////////////////////////////////////////////////////
// TASK DEFINITIONS
///////////////////////////////////////////////////////////////////////////////

Task("Clean")
	.Description("clean bin, obj, artifacts.")
	.Does(() =>
{
	var srcRootDir = parameters.Paths.Directories.SrcRootDir;
	var testsRootDir = parameters.Paths.Directories.TestsRootDir;
	var specsRootDir = parameters.Paths.Directories.SpecsRootDir;
	var configuration = parameters.Configuration;
	// Clean solution directories.
	Information("Cleaning source folder {0}", srcRootDir);
	CleanDirectories($"{srcRootDir}/**/bin/{configuration}");
	CleanDirectories($"{srcRootDir}/**/obj/{configuration}");

	
	Information("Cleaning test folders {0}", testsRootDir);
	CleanDirectories($"{testsRootDir}/**/bin/{configuration}");
	CleanDirectories($"{testsRootDir}/**/obj/{configuration}");

	Information("Cleaning specs folders {0}", specsRootDir);
	CleanDirectories($"{specsRootDir}/**/bin/{configuration}");
	CleanDirectories($"{specsRootDir}/**/obj/{configuration}");


	CleanDirectories(parameters.Paths.Directories.ToClean);        

    EnsureDirectoryExists(parameters.Paths.Directories.ArtifactsDir);
    EnsureDirectoryExists(parameters.Paths.Directories.TestResultsDir);
    EnsureDirectoryExists(parameters.Paths.Directories.NugetRootDir);


	// var outputDir = parameters.Paths.Directories.Artifacts;
	// // Clean previous artifacts
	// Information("Cleaning {0}", outputDir);
	// if (!DirectoryExists(outputDir)) CreateDirectory(outputDir);
	// if (DirectoryExists(publishDir)) CleanDirectories(MakeAbsolute(Directory(publishDir)).FullPath);
});

Task("Restore")
	.Description("Restore nuget packages.")
	.Does(() =>
{
	string solution = parameters.Paths.Files.Solution.ToString();
	string nugetServerUrl = parameters.NuGet.ApiUrl;
	Information("Restoring solution: {0}", solution);
	Information("Restoring NuGet url: {0}", nugetServerUrl);
	DotNetCoreRestore(solution, new DotNetCoreRestoreSettings
	{
		Verbosity = DotNetCoreVerbosity.Minimal,     
		Sources = new [] {nugetServerUrl}
	});
});

Task("Build")
	.Does(()=>
{
	string solution = parameters.Paths.Files.Solution.ToString();
	DotNetBuild(solution, settings => new DotNetCoreBuildSettings
	{
		Configuration = parameters.Configuration,
		NoRestore = true,
		ArgumentCustomization = args => args.Append($"/p:SemVer={parameters.Version.SemVersion}")
	});
});

Task("Tests-With_Coverage")
	.Description("Run tests and create test coverage reports.")
    .Does(() =>
	{
	Action<ICakeContext> testAction = context =>
  	{
		foreach(var testDir in parameters.Paths.Directories.TestDirs)
    	{
	 		var projects = GetFiles($"{testDir}/**/*.Test.csproj");
        	foreach(var project in projects)
        	{
				var vSTestReportPath  = $"{parameters.Paths.Directories.TestResultsDir.CombineWithFilePath(project.GetFilenameWithoutExtension()).FullPath}.xml";
				var settings = new DotNetCoreTestSettings
     				{
	    				Configuration = parameters.Configuration,
						OutputDirectory = parameters.Paths.Directories.TestResultsDir,
						ResultsDirectory = parameters.Paths.Directories.TestResultsDir,
						Verbosity = DotNetCoreVerbosity.Minimal,
						VSTestReportPath  = vSTestReportPath,
     				};
 					context.DotNetCoreTest(project.FullPath, settings);
        	}
		}
	 };
 
		
 	//     OpenCover(tool => testAction(tool),
    //                     parameters.Paths.Files.TestCoverageOutput,
    //                     new OpenCoverSettings()
    //                     {
    //                         ReturnTargetCodeOffset = 0,
    //                         OldStyle = true,
    //                         MergeOutput = true
    //                     }
    //                     .WithFilter($"+[{parameters.AppInfo.AppName}]*")
    //                     .WithFilter($"-[*.Test]*")
	// 					.ExcludeByAttribute("*.ExcludeFromCodeCoverage*")
    //                     .ExcludeByFile("*.Designer.cs;*.g.cs;*.g.i.cs"));
    //   ReportGenerator(parameters.Paths.Files.TestCoverageOutput, parameters.Paths.Directories.TestResultsCoverReportDir);
});


Task("Tests")
	.Description("Run tests and create test coverage reports.")
    .Does(() =>
	{
	Action<ICakeContext> testAction = context =>
  	{
		foreach(var testDir in parameters.Paths.Directories.TestDirs)
    	{
	 		var projects = GetFiles($"{testDir}/**/*.Test.csproj");
        	foreach(var project in projects)
        	{
				var vSTestReportPath  = $"{parameters.Paths.Directories.TestResultsDir.CombineWithFilePath(project.GetFilenameWithoutExtension()).FullPath}.xml";
				var settings = new DotNetCoreTestSettings
     				{
	    				Configuration = parameters.Configuration,
						OutputDirectory = parameters.Paths.Directories.TestResultsDir,
						ResultsDirectory = parameters.Paths.Directories.TestResultsDir,
						Verbosity = DotNetCoreVerbosity.Minimal,
						VSTestReportPath  = vSTestReportPath,
     				};
 					context.DotNetCoreTest(project.FullPath, settings);
        	}
		}
	 };
});

Task("Create-NuGet-Packages")
	.Description("Generates NuGet packages for each project.")
    .Does(() =>
    {    
		if(parameters.IsTagged)
		{             
			var settings = new DotNetCorePackSettings
			{
				Configuration = parameters.Configuration,
				OutputDirectory = parameters.Paths.Directories.NugetRootDir.ToString(),
			};
			var projectPath = parameters.Paths.Directories.SrcRootDir
							.Combine(parameters.AppInfo.AppName)
							.Combine($"{parameters.AppInfo.AppName}.csproj");
			DotNetCorePack(projectPath.ToString(), settings);
		}

    });
 Task("Push-Nuget-Packages")
	.Description("Push NuGet packages to nuget server.")
	.Does(() =>
	{
		if(parameters.IsTagged)
		{ 
			var nugetFiles = System.IO.Directory.GetFiles(parameters.Paths.Directories.NugetRootDir.ToString(), "*.nupkg")
											.Select(z => new FilePath(z)).ToList();
			var settings = new NuGetPushSettings()
			{
				Source = parameters.NuGet.ApiUrl,
				ApiKey = parameters.NuGet.ApiKey,
			};

			NuGetPush(nugetFiles, settings);
		}
	});
Task("Default")
	.IsDependentOn("Clean")
	.IsDependentOn("Restore")
	.IsDependentOn("Build")
	.IsDependentOn("Tests")
	.IsDependentOn("Create-NuGet-Packages")
	.IsDependentOn("Push-Nuget-Packages");

RunTarget(parameters.Target);

