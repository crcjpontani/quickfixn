using System;

namespace QuickFix
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISessionSchedule
    {
        /// <summary>
        /// Returns true if testtime is in a different and newer session than old time
        /// (or more explicitly: oldtime &lt;= some EndTime &lt; testtime)
        /// </summary>
        /// <param name="oldtimeUtc"></param>
        /// <param name="testtimeUtc"></param>
        /// <returns></returns>
        bool IsNewSession(DateTime oldtimeUtc, DateTime testtimeUtc);
        /// <summary>
        /// Returns true if the datetime falls within the session's configured time frame.
        /// </summary>
        /// <param name="utc"></param>
        /// <returns></returns>
        bool IsSessionTime(DateTime utc);
    }
}
