using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D m_rigidbody;
    [SerializeField]
    private float m_force;

    [SerializeField]
    private float m_evadeRatio;

    private static GameObject m_player = null;

    void Start()
    {
        if (m_player == null)
        {
            m_player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    public void SetPursue()
    {
        m_rigidbody.AddForce((m_player.transform.position - transform.position).normalized * m_force);
    }

    public void SetEvade()
    {
        m_rigidbody.AddForce(-(m_player.transform.position - transform.position).normalized * m_force * m_evadeRatio);

    }

    public void SetNeutral()
    {
        m_rigidbody.velocity *= .9f;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
