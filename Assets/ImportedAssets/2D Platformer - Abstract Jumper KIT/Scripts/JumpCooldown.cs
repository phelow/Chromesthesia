using UnityEngine;
using System.Collections;

public class JumpCooldown : MonoBehaviour {

	float jumpRate = 0.7f;
	private bool isJumping = false;
	private bool isJumping2 = false;
	public AudioClip JumpSound;

	void Start () {
	}
		

	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			 	if (isJumping == false) 
			{
				gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 35);
				GetComponent<AudioSource>().PlayOneShot(JumpSound, 2.7F);
				isJumping = true;
			}
		        else if (!isJumping2)
			{
				gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 45);
				GetComponent<AudioSource>().PlayOneShot(JumpSound, 2.7F);
				isJumping2 = true;
				StartCoroutine(JumpCooldown1());
			}
		 }
	}
		
	IEnumerator JumpCooldown1() {
		isJumping = true;
		isJumping2 = true;
		yield return new WaitForSeconds(jumpRate);
		isJumping = false;
		isJumping2 = false;
		yield break;
	}	
}



