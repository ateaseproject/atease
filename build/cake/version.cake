public class BuildVersion
{
    public GitVersion GitVersionInfo { get; private set; }
    public string Milestone {get;private set;}
    public string CakeVersion { get; private set; }
    public string SemVersion    { get; private set; }

    public static BuildVersion Calculate(ICakeContext context, bool isLocalBuild)
    {
        if (context == null)
        {
            throw new ArgumentNullException("context");
        }
        if (!isLocalBuild)
        {
            context.GitVersion(new GitVersionSettings{
                OutputType = GitVersionOutput.BuildServer
            });
        }

        GitVersion assertedVersions = context.GitVersion(new GitVersionSettings
        {
            OutputType = GitVersionOutput.Json,
        });

        var cakeVersion = typeof(ICakeContext).Assembly.GetName().Version.ToString();

        return new BuildVersion
        {
            GitVersionInfo = assertedVersions,
            Milestone = string.Concat("v", assertedVersions.MajorMinorPatch),
            SemVersion = assertedVersions.LegacySemVerPadded,
            CakeVersion = cakeVersion
        };
    }

    public bool IsDevelopment
    {
        get { return GitVersionInfo.BranchName.Equals("develop", StringComparison.CurrentCultureIgnoreCase); }
    }

    public bool IsRelease
    {
        get { return GitVersionInfo.BranchName.StartsWith("release", StringComparison.CurrentCultureIgnoreCase); }
    }

    public bool IsProduction
    {
        get { return GitVersionInfo.BranchName.Equals("master", StringComparison.CurrentCultureIgnoreCase); }
    }
}