namespace MiBand
{
    public interface IMiBandManagerStateHandler
    {
        void OnConnected ();
        void OnConnectionFailed ();        
    }
}