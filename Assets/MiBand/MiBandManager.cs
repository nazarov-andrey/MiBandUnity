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

        public void ListenHeartRate (string mac, IHeartrateListener heartrateListener)
        {
            miBand.ListenHeartRate (mac, heartrateListener);
        }

        public void StartHeartrateScan ()
        {
            miBand.StartHeartrateScan ();
        }
    }
}