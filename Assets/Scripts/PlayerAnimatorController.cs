using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{

    private Animator animator;
    private PlayerMovement movement;
    private Rigidbody rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        movement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("CharacterSpeed", rb.linearVelocity.magnitude);
        animator.SetBool("IsGrounded", movement.IsGrounded);

        if(Input.GetButtonUp("Fire1")){
            animator.SetTrigger("doRoll");
        }
    }
}
