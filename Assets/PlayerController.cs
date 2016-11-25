using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D m_rigidbody;

    [SerializeField]
    private float m_movementForce;
    [SerializeField]
    private float m_jumpForce;

    [SerializeField]
    private bool m_canJump = true;
    
    [SerializeField]
    private Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0.0f && m_canJump == true)
        {
            m_canJump = false;
            m_rigidbody.AddForce(m_jumpForce * transform.up);
            animator.SetTrigger("jump");
        }

        m_rigidbody.AddForce(transform.right * m_movementForce * Input.GetAxis("Horizontal"));
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            m_canJump = true;
        }
    }
}
