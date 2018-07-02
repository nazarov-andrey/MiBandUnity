using MiBand;
using UnityEngine;
using UnityEngine.UI;

public class EntryPoint : MonoBehaviour, IHeartrateListener, IMiBandManagerStateHandler
{
    [SerializeField]
    private Text text;

    private MiBandManager miBand = new MiBandManager ();

    private void Start ()
    {
        miBand.Connect ("C9:96:8C:EF:25:FA", this);
    }

    public void OnHeartRate (int heartRate)
    {
        Debug.Log ("EntryPoint.OnHeartRate" + heartRate);
        text.text = "Heartrate: " + heartRate;
    }

    public void ScanHeartRate ()
    {
        Debug.Log ("ScanHeartRate " + miBand);
//        miBand.StartHeartrateScan (null);
    }

    public void OnConnected ()
    {
        miBand.SetHeartRateListener (this);
    }

    public void OnConnectionFailed ()
    {
    }
}