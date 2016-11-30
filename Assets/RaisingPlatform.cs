using UnityEngine;
using System.Collections;

public class RaisingPlatform : MonoBehaviour {

    [SerializeField]
    private GameObject m_minHeightMarker;
    [SerializeField]
    private GameObject m_maxHeightMarker;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoToHeight(float lerpAmount)
    {
        transform.position = Vector3.Lerp(m_minHeightMarker.transform.position, m_maxHeightMarker.transform.position, lerpAmount);
    }
}
