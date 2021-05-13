using System.Runtime.InteropServices;

namespace AtEase.Extensions.OperatingSystem
{
    public static class OperatingSystemExtensions
    {
        /// <summary>
        /// Determines  OS is Windows or not.
        /// </summary>
        /// <returns>rue if OS is Windows</returns>
        public static bool IsWindows()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        }
        /// <summary>
        /// Determines  OS is MacOs or not.
        /// </summary>
        /// <returns>rue if OS is MacOs</returns>
        public static bool IsMacOs()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        }
        /// <summary>
        /// Determines  OS is Linux or not.
        /// </summary>
        /// <returns>rue if OS is Linux</returns>
        public static bool IsLinux()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        }
    }
}