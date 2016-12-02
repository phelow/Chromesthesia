using UnityEngine;
using System.Collections;

public class MovingPlatFormManager : MonoBehaviour {
    [SerializeField]
    private MovingPlatform[] m_movingPlatforms;
	// Use this for initialization
	void Start () {

        Hv_MovingPlatform_AudioLib script = GetComponent<Hv_MovingPlatform_AudioLib>();
        script.RegisterSendHook();
        script.FloatReceivedCallback += OnFloatMessage;
    }

    void OnFloatMessage(Hv_MovingPlatform_AudioLib.FloatMessage message)
    {
        Debug.Log(message.receiverName + ": " + message.value);
        if (message.value == 1)
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
