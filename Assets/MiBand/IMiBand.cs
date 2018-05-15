
namespace MiBand
{
    public interface IMiBand
    {
        void ListenHeartRate (string mac, IHeartrateListener heartrateListener);
        void StartHeartrateScan ();
    }
}

