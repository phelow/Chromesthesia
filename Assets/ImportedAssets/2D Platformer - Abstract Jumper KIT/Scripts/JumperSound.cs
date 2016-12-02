using UnityEngine;
using System.Collections;

public class JumperSound : MonoBehaviour {
	public AudioClip Sound;

    public Hv_RandomWalk_AudioLib m_audioLib;

    public float m_nextState;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player")
        {
            m_audioLib.SetFloatParameter(Hv_RandomWalk_AudioLib.Parameter.Unity_state, 0);
            m_audioLib.SetFloatParameter(Hv_RandomWalk_AudioLib.Parameter.Unity_state, m_nextState);

            GetComponent<AudioSource>().PlayOneShot(Sound, 2.7F);
		}
	}
}
