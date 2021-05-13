using System;
using System.Diagnostics;

namespace AtEase.Extensions.OperatingSystem
{
    public static class ProcessExtensions
    {
        /// <summary>
        ///     Run cmd (process).
        /// </summary>
        /// <param name="cmd">command</param>
        /// <param name="workingDirectory">working directory</param>
        /// <returns>the output of command</returns>
        public static string RunAsCmd(this string cmd, string workingDirectory = null)
        {
            if (OperatingSystemExtensions.IsWindows())
            {
                return RunAsWindowsCmd(cmd, workingDirectory);
            }

            if (OperatingSystemExtensions.IsLinux())
            {
                return RunAsBashCmd(cmd, workingDirectory);
            }

            throw new Exception(@"Operation system doesn't recognized.");
        }

        /// <summary>
        ///     Run cmd (process).
        /// </summary>
        /// <param name="cmd">command</param>
        /// <param name="workingDirectory">working directory</param>
        /// <returns>the output of command</returns>
        public static string RunAsWindowsCmd(this string cmd, string workingDirectory = null)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c {cmd}"
            };

            return RunProcess(processStartInfo, workingDirectory);
        }

        /// <summary>
        ///     Run cmd (process).
        /// </summary>
        /// <param name="cmd">command</param>
        /// <param name="workingDirectory">working directory</param>
        /// <returns>the output of command</returns>
        public static string RunAsBashCmd(this string cmd, string workingDirectory = null)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "/bin/bash",
                Arguments = $"/c -c \"{cmd}\""
            };
            return RunProcess(processStartInfo, workingDirectory);
        }


        private static string RunProcess(ProcessStartInfo processStartInfo, string workingDirectory = null)
        {
            if (workingDirectory.IsNotNull())
            {
                processStartInfo.WorkingDirectory = workingDirectory;
            }

            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;

            processStartInfo.CreateNoWindow = true;
            var process = new Process
            {
                StartInfo = processStartInfo
            };
            process.Start();
            var result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return result;
        }
    }
}