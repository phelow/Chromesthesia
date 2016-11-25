using UnityEngine;
using System.Collections;

public class WalkAnimation : MonoBehaviour
{

    private Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        var horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("walkspeed", Mathf.Abs(horizontal));
    }
}