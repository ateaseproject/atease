using Hangfire.Console;
using Microsoft.Extensions.Logging;

namespace Achehre.Framework.HangFire.Console.LogExtension
{
    /// <summary>Configuration options for console logger.</summary>
    public class ConsoleLoggerOptions
    {
        public ConsoleLoggerOptions()
        {
            TraceColor = ConsoleTextColor.Green;

            DebugColor = ConsoleTextColor.Gray;

            InformationColor = ConsoleTextColor.DarkGray;

            WarningColor = ConsoleTextColor.Yellow;

            ErrorColor = ConsoleTextColor.Red;

            CriticalColor = ConsoleTextColor.DarkRed;
            DefaultColor = ConsoleTextColor.White;
        }

        public ConsoleTextColor TraceColor { get; set; }
        public ConsoleTextColor DebugColor { get; set; }
        public ConsoleTextColor InformationColor { get; set; }
        public ConsoleTextColor WarningColor { get; set; }
        public ConsoleTextColor ErrorColor { get; set; }
        public ConsoleTextColor CriticalColor { get; set; }
        public ConsoleTextColor DefaultColor { get; set; }


        internal ConsoleTextColor GetColor(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Trace:
                    return TraceColor;
                case LogLevel.Debug:
                    return DebugColor;
                case LogLevel.Information:
                    return InformationColor;
                case LogLevel.Warning:
                    return WarningColor;
                case LogLevel.Error:
                    return ErrorColor;
                case LogLevel.Critical:
                    return CriticalColor;
                case LogLevel.None:
                    return DefaultColor;
                default:
                    return DefaultColor;
            }
        }
    }
}