using UnityEngine;
using System.Collections;



public class DisplayText : MonoBehaviour
{

    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D otherObject)
    {

        if (otherObject.tag == "Player")
        {
            rend.enabled = true;
            //GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D otherObject)
    {


        rend.enabled = false;
        Destroy(gameObject);
        {


        }
    }

}