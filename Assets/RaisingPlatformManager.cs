using UnityEngine;
using System.Collections;

public class RaisingPlatformManager : MonoBehaviour {
    [SerializeField]
    private RaisingPlatform[] m_raisingPlatforms;

    [SerializeField]
    private float m_minPitch;
    [SerializeField]
    private float m_maxPitch;
    // Use this for initialization
    void Start () {

        Hv_RaisingPlatform_AudioLib script = GetComponent<Hv_RaisingPlatform_AudioLib>();
        script.RegisterSendHook();
        script.FloatReceivedCallback += OnFloatMessage;
    }


    void OnFloatMessage(Hv_RaisingPlatform_AudioLib.FloatMessage message)
    {
        Debug.Log(message.receiverName + ": " + message.value);

        if(message.receiverName == "#unity_pitch")
        {
            foreach(RaisingPlatform rp in m_raisingPlatforms)
            {
                rp.GoToHeight(Mathf.InverseLerp(m_minPitch, m_maxPitch, message.value));
            }
        }

    }
}
