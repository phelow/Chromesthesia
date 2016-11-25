using UnityEngine;
using System.Collections;
using System.Linq;

public class CheckPoint : MonoBehaviour{
    private bool m_active = false;
    public static CheckPoint m_lastCheckPoint;

    [SerializeField]
    private GameObject m_respawnPoint;

    [SerializeField]
    private Sprite m_inactiveSprite;
    [SerializeField]
    private bool m_isFirstCheckpoint;

    [SerializeField]
    private Sprite m_activeSprite;

    [SerializeField]
    private SpriteRenderer m_spriteRenderer;

    public static void ClearAllCheckPoints() {
        CheckPoint [] checkPoints = GameObject.FindGameObjectsWithTag("CheckPoint").Select(item => item.GetComponent<CheckPoint>()).ToArray();

        foreach(CheckPoint chkpt in checkPoints)
        {
            chkpt.SetInactiveSprite();
        }

    }

    public GameObject GetRespawnPoint()
    {
        return m_respawnPoint;
    }

    public void SetInactiveSprite()
    {
        m_spriteRenderer.sprite = m_inactiveSprite;
    }


    public void SetActiveSprite()
    {
        m_spriteRenderer.sprite = m_activeSprite;
    }

    public void ActivateCheckpoint()
    {
        CheckPoint.ClearAllCheckPoints();
        this.SetActive();

    }

    public void SetActive()
    {
        this.SetActiveSprite();
        this.m_active = true;
        m_lastCheckPoint = this;

    }

    void Start()
    {
        if (m_isFirstCheckpoint)
        {
            this.SetActive();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.transform.tag == "Player")
        {
            ActivateCheckpoint();
        }
    }

}
