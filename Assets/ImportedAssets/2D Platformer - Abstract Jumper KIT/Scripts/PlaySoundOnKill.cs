using UnityEngine;
using System.Collections;

public class PlaySoundOnKill : MonoBehaviour {

	public AudioClip HurtSound;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D otherObject)
	{
		if (otherObject.tag == "hitzone")
		{
			GetComponent<AudioSource>().PlayOneShot(HurtSound, 2.7F);
		}
	
	}
}