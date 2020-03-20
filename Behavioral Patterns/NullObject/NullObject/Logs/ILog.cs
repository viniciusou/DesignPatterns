namespace NullObject.Logs
{
    public interface ILog
    {
        void Info(string message);
        void Warn(string message);
    }
}
