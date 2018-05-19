namespace MiBand
{
    public interface IMiBand
    {
        void Connect (string mac, IMiBandManagerStateHandler handler);
        void StartHeartrateScan (IHeartRateScanStartHandler handler);
        void SetHeartRateListener (IHeartrateListener heartrateListener);
    }
}