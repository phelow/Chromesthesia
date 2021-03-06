using UnityEngine;
using System.Collections;

public class FlipPlayer : MonoBehaviour {

	private bool facingRight;

	void Start () {
		facingRight = true;
	
	}

	void Update () {

		transform.Translate (Vector3.down * 0 * Time.deltaTime * Input.GetAxis ("Horizontal"));

		float horizontal = Input.GetAxis("Horizontal");
		
		Flip(horizontal);

	}

	private void Flip(float horizontal)
	{
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
			{
		facingRight = !facingRight;
		
		Vector3 theScale = transform.localScale;
		
		theScale.x *= -1;
		
		transform.localScale = theScale;
			}
		}
	}
