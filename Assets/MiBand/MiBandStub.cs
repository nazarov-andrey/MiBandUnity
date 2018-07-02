using System;

namespace MiBand
{
    public class MiBandStub : IMiBand
    {
        public void Connect (string mac, IMiBandManagerStateHandler handler)
        {
            
        }

        public void StartHeartrateScan (Action success, Action failed)
        {
            
        }

        public void ContinueHeartRateScane ()
        {
            
        }

        public void StopHeartrateScan (Action success, Action failed)
        {
            
        }

        public void SetHeartRateListener (IHeartrateListener heartrateListener)
        {
            
        }

        public void RequestHeartRateState ()
        {
            
        }
    }
}