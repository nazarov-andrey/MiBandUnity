using UnityEngine;

namespace MiBand
{
    public class MiBandManager : IMiBand
    {
        private IMiBand miBand;

        public MiBandManager ()
        {
            if (Application.platform == RuntimePlatform.Android)
                miBand = new MiBandAndroid ();
            else
                miBand = new MiBandStub ();
        }

        public void Connect (string mac, IMiBandManagerStateHandler handler)
        {
            miBand.Connect (mac, handler);
        }

        public void StartHeartrateScan (IHeartRateScanStartHandler handler)
        {
            miBand.StartHeartrateScan (handler);
        }

        public void SetHeartRateListener (IHeartrateListener heartrateListener)
        {
            miBand.SetHeartRateListener (heartrateListener);
        }
    }
}