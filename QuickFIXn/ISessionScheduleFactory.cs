namespace QuickFix
{
    /// <summary>
    /// Used by Session to create a SessionSchedule of the appropriate type.
    /// </summary>
    public interface ISessionScheduleFactory
    {
        /// <summary>
        /// Create a new session schedule for a given session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        ISessionSchedule Create(SessionID sessionId, SettingsDictionary settings);
    }
}
