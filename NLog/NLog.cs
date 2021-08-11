using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace SessionNLog
{
    public class NLog
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Fine -grained statements concerning program state, typically used for debugging
        /// </summary>
        /// <param name="message"></param>
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        /// <summary>
        /// Statements that describe non-fatal errors in application.
        /// This level is used quite often for logging exceptions.
        /// </summary>
        /// <param name="message"></param>
        public void LogError(string message)
        {
            logger.Error(message);
        }

        /// <summary>
        /// Statements that describe potentially harmful events or states in program 
        /// </summary>
        /// <param name="message"></param>
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }

        /// <summary>
        /// Informational statements concerning program start, representing program events or behavior tracking
        /// </summary>
        /// <param name="message"></param>
        public void LogInfo(string message)
        {
            logger.Info(message);
        }
    }
}
