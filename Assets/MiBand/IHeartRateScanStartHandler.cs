namespace MiBand
{
    public interface IHeartRateScanStartHandler
    {
        void OnSuccess ();
        void OnFailed ();        
    }
}