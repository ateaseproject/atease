using System;
using System.Globalization;
using Hangfire.Console;
using Hangfire.Server;
using Microsoft.Extensions.Logging;

namespace Achehre.Framework.HangFire.Console.LogExtension
{
    public static class HangfireLoggerExtensions
    {
        //------------------------------------------DEBUG------------------------------------------//

        /// <summary>
        ///     Formats and writes a debug log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogDebug(0, exception, "Error while processing request from {Address}", address)</example>
        public static void LogDebug(this ILogger logger, PerformContext performContext, EventId eventId,
                                    Exception exception, string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Debug, eventId, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes a debug log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogDebug(0, "Processing request from {Address}", address)</example>
        public static void LogDebug(this ILogger logger, PerformContext performContext, EventId eventId, string message,
                                    params object[] args)
        {
            logger.Log(performContext, LogLevel.Debug, eventId, message, args);
        }

        /// <summary>
        ///     Formats and writes a debug log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogDebug(exception, "Error while processing request from {Address}", address)</example>
        public static void LogDebug(this ILogger logger, PerformContext performContext, Exception exception,
                                    string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Debug, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes a debug log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogDebug("Processing request from {Address}", address)</example>
        public static void LogDebug(this ILogger logger, PerformContext performContext, string message,
                                    params object[] args)
        {
            logger.Log(performContext, LogLevel.Debug, message, args);
        }

        //------------------------------------------TRACE------------------------------------------//

        /// <summary>
        ///     Formats and writes a trace log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogTrace(0, exception, "Error while processing request from {Address}", address)</example>
        public static void LogTrace(this ILogger logger, PerformContext performContext, EventId eventId,
                                    Exception exception, string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Trace, eventId, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes a trace log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogTrace(0, "Processing request from {Address}", address)</example>
        public static void LogTrace(this ILogger logger, PerformContext performContext, EventId eventId, string message,
                                    params object[] args)
        {
            logger.Log(performContext, LogLevel.Trace, eventId, message, args);
        }

        /// <summary>
        ///     Formats and writes a trace log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogTrace(exception, "Error while processing request from {Address}", address)</example>
        public static void LogTrace(this ILogger logger, PerformContext performContext, Exception exception,
                                    string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Trace, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes a trace log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogTrace("Processing request from {Address}", address)</example>
        public static void LogTrace(this ILogger logger, PerformContext performContext, string message,
                                    params object[] args)
        {
            logger.Log(performContext, LogLevel.Trace, message, args);
        }

        //------------------------------------------INFORMATION------------------------------------------//

        /// <summary>
        ///     Formats and writes an informational log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogInformation(0, exception, "Error while processing request from {Address}", address)</example>
        public static void LogInformation(this ILogger logger, PerformContext performContext, EventId eventId,
                                          Exception exception, string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Information, eventId, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes an informational log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogInformation(0, "Processing request from {Address}", address)</example>
        public static void LogInformation(this ILogger logger, PerformContext performContext, EventId eventId,
                                          string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Information, eventId, message, args);
        }

        /// <summary>
        ///     Formats and writes an informational log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogInformation(exception, "Error while processing request from {Address}", address)</example>
        public static void LogInformation(this ILogger logger, PerformContext performContext, Exception exception,
                                          string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Information, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes an informational log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogInformation("Processing request from {Address}", address)</example>
        public static void LogInformation(this ILogger logger, PerformContext performContext, string message,
                                          params object[] args)
        {
            logger.Log(performContext, LogLevel.Information, message, args);
        }

        //------------------------------------------WARNING------------------------------------------//

        /// <summary>
        ///     Formats and writes a warning log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogWarning(0, exception, "Error while processing request from {Address}", address)</example>
        public static void LogWarning(this ILogger logger, PerformContext performContext, EventId eventId,
                                      Exception exception, string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Warning, eventId, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes a warning log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogWarning(0, "Processing request from {Address}", address)</example>
        public static void LogWarning(this ILogger logger, PerformContext performContext, EventId eventId,
                                      string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Warning, eventId, message, args);
        }

        /// <summary>
        ///     Formats and writes a warning log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogWarning(exception, "Error while processing request from {Address}", address)</example>
        public static void LogWarning(this ILogger logger, PerformContext performContext, Exception exception,
                                      string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Warning, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes a warning log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogWarning("Processing request from {Address}", address)</example>
        public static void LogWarning(this ILogger logger, PerformContext performContext, string message,
                                      params object[] args)
        {
            logger.Log(performContext, LogLevel.Warning, message, args);
        }

        //------------------------------------------ERROR------------------------------------------//

        /// <summary>
        ///     Formats and writes an error log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogError(0, exception, "Error while processing request from {Address}", address)</example>
        public static void LogError(this ILogger logger, PerformContext performContext, EventId eventId,
                                    Exception exception, string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Error, eventId, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes an error log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogError(0, "Processing request from {Address}", address)</example>
        public static void LogError(this ILogger logger, PerformContext performContext, EventId eventId, string message,
                                    params object[] args)
        {
            logger.Log(performContext, LogLevel.Error, eventId, message, args);
        }

        /// <summary>
        ///     Formats and writes an error log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogError(exception, "Error while processing request from {Address}", address)</example>
        public static void LogError(this ILogger logger, PerformContext performContext, Exception exception,
                                    string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Error, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes an error log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogError("Processing request from {Address}", address)</example>
        public static void LogError(this ILogger logger, PerformContext performContext, string message,
                                    params object[] args)
        {
            logger.Log(performContext, LogLevel.Error, message, args);
        }

        //------------------------------------------CRITICAL------------------------------------------//

        /// <summary>
        ///     Formats and writes a critical log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogCritical(0, exception, "Error while processing request from {Address}", address)</example>
        public static void LogCritical(this ILogger logger, PerformContext performContext, EventId eventId,
                                       Exception exception, string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Critical, eventId, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes a critical log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogCritical(0, "Processing request from {Address}", address)</example>
        public static void LogCritical(this ILogger logger, PerformContext performContext, EventId eventId,
                                       string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Critical, eventId, message, args);
        }

        /// <summary>
        ///     Formats and writes a critical log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogCritical(exception, "Error while processing request from {Address}", address)</example>
        public static void LogCritical(this ILogger logger, PerformContext performContext, Exception exception,
                                       string message, params object[] args)
        {
            logger.Log(performContext, LogLevel.Critical, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes a critical log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="message">
        ///     Format string of the log message in message template format. Example:
        ///     <code>"User {User} logged in from {Address}"</code>
        /// </param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>logger.LogCritical("Processing request from {Address}", address)</example>
        public static void LogCritical(this ILogger logger, PerformContext performContext, string message,
                                       params object[] args)
        {
            logger.Log(performContext, LogLevel.Critical, message, args);
        }

        /// <summary>
        ///     Formats and writes a log message at the specified log level.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="logLevel">Entry will be written on this level.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void Log(this ILogger logger, PerformContext performContext, LogLevel logLevel, string message,
                               params object[] args)
        {
            logger.Log(performContext, logLevel, 0, null, message, args);
        }

        /// <summary>
        ///     Formats and writes a log message at the specified log level.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="logLevel">Entry will be written on this level.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void Log(this ILogger logger, PerformContext performContext, LogLevel logLevel, EventId eventId,
                               string message, params object[] args)
        {
            logger.Log(performContext, logLevel, eventId, null, message, args);
        }

        /// <summary>
        ///     Formats and writes a log message at the specified log level.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="logLevel">Entry will be written on this level.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void Log(this ILogger logger, PerformContext performContext, LogLevel logLevel,
                               Exception exception, string message, params object[] args)
        {
            logger.Log(performContext, logLevel, 0, exception, message, args);
        }

        /// <summary>
        ///     Formats and writes a log message at the specified log level.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to write to.</param>
        /// <param name="logLevel">Entry will be written on this level.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void Log(this ILogger logger, PerformContext performContext, LogLevel logLevel, EventId eventId,
                               Exception exception, string message, params object[] args)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            ConsoleTextColor color = null;
            switch (logLevel)
            {
                case LogLevel.Trace:
                    color = ConsoleTextColor.Green;
                    break;
                case LogLevel.Debug:
                    color = ConsoleTextColor.Gray;
                    break;
                case LogLevel.Information:
                    color = ConsoleTextColor.DarkGray;
                    break;
                case LogLevel.Warning:
                    color = ConsoleTextColor.Yellow;
                    break;
                case LogLevel.Error:
                    color = ConsoleTextColor.Red;
                    break;
                case LogLevel.Critical:
                    color = ConsoleTextColor.DarkRed;
                    break;
                case LogLevel.None:
                    color = ConsoleTextColor.White;
                    break;
                default:
                    color = ConsoleTextColor.White;
                    break;
            }


            var formattedMessage = string.Format(message, args);
            var timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff",
                                                     CultureInfo.InvariantCulture);

            performContext.WriteLine(color,
                                     "[{0}] LogLevel: {1}, EventId: {2}, Message: \"{3}\", Exception: {4}, OriginalMessage: {5},Args: {6}",
                                     timestamp,
                                     logLevel.ToString(), eventId, formattedMessage, exception, message, args);

            logger.Log(logLevel, eventId, exception, message, args);
        }
    }
}