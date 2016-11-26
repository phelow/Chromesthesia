using UnityEngine;
using System.Collections;

public class MovingPlatFormManager : MonoBehaviour {
    [SerializeField]
    private MovingPlatform[] m_movingPlatforms;
	// Use this for initialization
	void Start () {

        Hv_MovingPlatform_LibWrapper script = GetComponent<Hv_MovingPlatform_LibWrapper>();
        script.RegisterSendHook();
        script.FloatReceivedCallback += OnFloatMessage;
    }

    void OnFloatMessage(Hv_MovingPlatform_LibWrapper.FloatMessage message)
    {
        Debug.Log(message.receiverName + ": " + message.value);
        if (message.receiverName == "#unity_metro3_bang")
        {
            foreach(MovingPlatform mp in m_movingPlatforms)
            {
                mp.BleepGrey();
            }

        }

        if (message.receiverName == "#unity_metro1_bang")
        {
            foreach (MovingPlatform mp in m_movingPlatforms)
            {
                mp.GoToNextPosition();
            }
        }


    }

    // Update is called once per frame
    void Update () {
	
	}
}
