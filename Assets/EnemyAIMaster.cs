using UnityEngine;
using System.Collections;

public class EnemyAIMaster : MonoBehaviour {

    [SerializeField]
    private EnemyAI [] m_enemyAIs;

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

        if(message.receiverName == "#unity_ai")
        {
            if( message.value < 72)
            {
                foreach(EnemyAI ai in m_enemyAIs)
                {
                    ai.SetPursue();
                }
            }else if (message.value >= 72 && message.value < 84)
            {
                foreach (EnemyAI ai in m_enemyAIs)
                {
                    ai.SetNeutral();
                }

            }
            else if(message.value >= 84)
            {

                foreach (EnemyAI ai in m_enemyAIs)
                {
                    ai.SetEvade();
                }

            }
        }

    }
}
