using UnityEngine;
using System.Collections;

public class DoubleJump : MonoBehaviour {


	public float jumpHeight;
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
			}

		}
	}

	//this bit is to check if the object that collided with it has the ground tag
	void OnCollisionEnter2D(Collision2D collide)
	{
		if(collide.gameObject.tag == "ground")
			    {
			isJumping = false;
			isJumping2 = false;
			     }
	}	

}