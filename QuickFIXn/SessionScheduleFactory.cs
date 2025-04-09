namespace QuickFix
{
    /// <summary>
    /// The default factory for creating SessionSchedule instances.
    /// </summary>
    public class DefaultSessionScheduleFactory : ISessionScheduleFactory
    {
        public ISessionSchedule Create(SessionID sessionId, SettingsDictionary settings)
        {
            return new SessionSchedule(settings);
        }
    }
}
