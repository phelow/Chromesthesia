using UnityEngine;
using System.Collections;

public class KillPlayerOnCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.tag == "Player")
        {
            KillPlayer.ReturnToLastCheckpoint();
        }
    }
}
