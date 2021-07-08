using System;
using System.Linq;
using AtEase.Extensions;
using static Nuke.Common.Tools.Git.GitTasks;

public class GitHelper
{
    public static string GetCurrentGitTag()
    {
        var outputs = Git("describe --exact-match --tags", logOutput: false);

        if (outputs.Any())
        {
            return outputs.First().Text;
        }

        Console.WriteLine("No Git tag found for current commit");
        return null;
    }

    public static BuildPackage GetBuildPackage()
    {
        var gitTag = GetCurrentGitTag();
        if (gitTag.IsNullOrEmptyOrWhiteSpace())
        {
            return null;
        }

        var index = gitTag.IndexOfAny("0123456789".ToCharArray());

        return new BuildPackage
        {
            Name = gitTag.Substring(0, index),
            Version = gitTag.Substring(index, gitTag.Length - index)
        };
    }
}

public class BuildPackage
{
    public string Name { get; set; }
    public string Version { get; set; }
}