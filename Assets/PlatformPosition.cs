using UnityEngine;
using System.Collections;

public class PlatformPosition : MonoBehaviour {

    [SerializeField]
    private PlatformPosition m_nextPosition;


    public PlatformPosition GetNextPosition()
    {
        return m_nextPosition;
    }

	// Use this for initialization
	void Start () {
	
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, .1f);
    }
    // Update is called once per frame
    void Update () {
	
	}
}
