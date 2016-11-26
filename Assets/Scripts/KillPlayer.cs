using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour
{
    public static KillPlayer ms_instance;
    public CheckPoint m_lastCheckPoint;

    [SerializeField]
    private PlayerController m_player;

    public static void ReturnToLastCheckpoint()
    {
        ms_instance.m_player.ReturnToLastCheckPoint();
    }

    // Use this for initialization
    void Start()
    {
        ms_instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
