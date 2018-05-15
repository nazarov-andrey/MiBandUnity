using UnityEngine;

namespace MiBand
{
    public class MiBandAndroid : IMiBand
    {
        class HeartrateListener : AndroidJavaProxy
        {
            private IHeartrateListener heartrateListener;

            public HeartrateListener (IHeartrateListener heartrateListener) : base (
                "com.khmelenko.lab.miband.IHeartrateListener")
            {
                this.heartrateListener = heartrateListener;
            }

            public void OnHeartRate (int heartRate)
            {
                heartrateListener.OnHeartRate (heartRate);
            }
        }

        private static string TAG = "MiBand";

        private AndroidJavaObject manager;

        private AndroidJavaObject GetManager ()
        {
            if (manager == null) {
                AndroidJavaClass jc = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
                AndroidJavaObject activity = jc.GetStatic<AndroidJavaObject> ("currentActivity");

                manager = new AndroidJavaObject ("com.khmelenko.lab.miband.MiBandManager", activity);
            }

            return manager;
        }

        public void ListenHeartRate (string mac, IHeartrateListener heartrateListener)
        {
            GetManager ().Call ("ListenHeartRate", mac, new HeartrateListener (heartrateListener));
        }

        public void StartHeartrateScan ()
        {
            GetManager ().Call ("StartHeartRateScan");
        }
    }
}