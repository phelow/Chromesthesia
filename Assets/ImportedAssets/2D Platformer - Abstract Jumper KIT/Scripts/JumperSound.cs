using UnityEngine;
using System.Collections;

public class JumperSound : MonoBehaviour {
	public AudioClip Sound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "jumper") 
		{
			GetComponent<AudioSource>().PlayOneShot(Sound, 2.7F);
		}
	}
}
