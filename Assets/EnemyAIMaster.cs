using UnityEngine;
using System.Collections;

public class EnemyAIMaster : MonoBehaviour {

    [SerializeField]
    private Hv_RandomWalk_AudioLib m_aiAudioLib;
    // Use this for initialization
    void Start()
    {
        Hv_RandomWalk_AudioLib script = GetComponent<Hv_RandomWalk_AudioLib>();
        script.RegisterSendHook();
        script.FloatReceivedCallback += OnFloatMessage;
    }

    void OnFloatMessage(Hv_RandomWalk_AudioLib.FloatMessage message)
    {
        Debug.Log(message.receiverName + ": " + message.value);


    }
}
