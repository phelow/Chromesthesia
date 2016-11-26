using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

    [SerializeField]
    private SpriteRenderer [] m_spriteRenderer;

    [SerializeField]
    private PlatformPosition m_nextPosition;

    void Start () {
    }

    public void BleepGrey()
    {
        foreach (SpriteRenderer sr in m_spriteRenderer)
        {
            sr.color = Color.Lerp(sr.color, Color.grey, 0.1f);

        }
    }

    public void GoToNextPosition()
    {
        this.transform.position = m_nextPosition.transform.position;
        m_nextPosition = m_nextPosition.GetNextPosition();
    }
	
	// Update is called once per frame
	void Update ()
    {
        foreach (SpriteRenderer sr in m_spriteRenderer)
        {
            sr.color = Color.Lerp(sr.color, Color.white, Time.deltaTime);

        }

    }
}
