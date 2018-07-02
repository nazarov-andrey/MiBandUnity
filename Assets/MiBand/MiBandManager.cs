using System;
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

        public void StartHeartrateScan (Action success, Action failed)
        {
            miBand.StartHeartrateScan (success, failed);
        }

        public void ContinueHeartRateScane ()
        {
            miBand.ContinueHeartRateScane ();
        }

        public void StopHeartrateScan (Action success, Action failed)
        {
            miBand.StopHeartrateScan (success, failed);
        }

        public void SetHeartRateListener (IHeartrateListener heartrateListener)
        {
            miBand.SetHeartRateListener (heartrateListener);
        }

        public void RequestHeartRateState ()
        {
            miBand.RequestHeartRateState ();
        }
    }
}