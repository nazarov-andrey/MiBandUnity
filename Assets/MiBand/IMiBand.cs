using System;

namespace MiBand
{
    public interface IMiBand
    {
        void Connect (string mac, IMiBandManagerStateHandler handler);
        void StartHeartrateScan (Action success, Action failed);
        void ContinueHeartRateScane ();
        void StopHeartrateScan (Action success, Action failed);
        void SetHeartRateListener (IHeartrateListener heartrateListener);
        void RequestHeartRateState ();
    }
}