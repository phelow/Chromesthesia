using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D m_rigidbody;

    [SerializeField]
    private AudioSource m_playerAudioSource;

    [SerializeField]
    private AudioClip m_jumpAudioClip;

    [SerializeField]
    private float m_movementForce;
    [SerializeField]
    private float m_jumpForce;

    [SerializeField]
    private float m_initialJumpForce;

    [SerializeField]
    private bool m_onGround = true;
    
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float m_aerialFactor;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0.0f && m_onGround == true)
        {
            m_onGround = false;
            StartCoroutine(JumpForceRoutine());

        }

        animator.SetFloat("walkspeed", Mathf.Abs(m_rigidbody.velocity.magnitude));

        if (m_onGround)
        {
            m_rigidbody.AddForce(transform.right * m_movementForce * Input.GetAxis("Horizontal"));
        }
        else
        {
            m_rigidbody.AddForce(transform.right * m_movementForce * Input.GetAxis("Horizontal") * m_aerialFactor);

        }
    }

    private IEnumerator JumpForceRoutine()
    {
        animator.SetTrigger("jump");
        m_playerAudioSource.PlayOneShot(m_jumpAudioClip);
        float f = 0.0f;
        m_rigidbody.AddForce(m_initialJumpForce * transform.up);
        while (f < .1f)
        {
            f += Time.fixedDeltaTime;
            yield return new WaitForFixedUpdate();
            m_rigidbody.AddForce(m_jumpForce * transform.up * Time.fixedDeltaTime);
        }


    }

    public void ReturnToLastCheckPoint()
    {
        transform.position = CheckPoint.m_lastCheckPoint.GetRespawnPoint().transform.position;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            m_onGround = true;
        }
    }
}
