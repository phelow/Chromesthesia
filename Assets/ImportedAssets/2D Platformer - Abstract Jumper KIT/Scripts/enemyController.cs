using UnityEngine;
using System.Collections;

public class enemyController : MonoBehaviour {

		public int health=100;

	    void OnTriggerEnter2D(Collider2D otherObject)
    {
		if ((otherObject.tag == "killzone") || (otherObject.tag == "trap"))
    {
        health -= 100;
		health--;

		if (health < 0){ 
		//AudioSource.PlayClipAtPoint(DieSound, transform.position);
		Destroy(this.gameObject);
		//Destroy(otherObject.gameObject);
			}
		}
	}
}
		
