using UnityEngine;

namespace MiBand
{
    public class MiBandAndroid : IMiBand
    {
        class MiBandManagerStateHandler : AndroidJavaProxy
        {
            private IMiBandManagerStateHandler handler;

            public MiBandManagerStateHandler (IMiBandManagerStateHandler handler) : base (
                "com.khmelenko.lab.miband.IMiBandManagerStateHandler")
            {
                this.handler = handler;
            }

            public void OnConnected ()
            {
                handler.OnConnected ();
            }

            public void OnConnectionFailed ()
            {
                handler.OnConnectionFailed ();
            }
        }

        class HeartRateScanStartHandler : AndroidJavaProxy
        {
            private IHeartRateScanStartHandler handler;

            public HeartRateScanStartHandler (IHeartRateScanStartHandler handler)
                : base ("com.khmelenko.lab.miband.IHeartRateScanStartHandler")
            {
                this.handler = handler;
            }

            public void OnSuccess ()
            {
                handler.OnSuccess ();
            }

            public void OnFailed ()
            {
                handler.OnFailed ();
            }
        }

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

        public void Connect (string mac, IMiBandManagerStateHandler handler)
        {
            GetManager ().Call ("Connect", mac, new MiBandManagerStateHandler (handler));
        }

        public void StartHeartrateScan (IHeartRateScanStartHandler handler)
        {
            GetManager ().Call ("StartHeartRateScan", new HeartRateScanStartHandler (handler));
        }

        public void SetHeartRateListener (IHeartrateListener heartrateListener)
        {
            GetManager ().Call ("SetHeartRateListener", new HeartrateListener (heartrateListener));
        }
    }
}