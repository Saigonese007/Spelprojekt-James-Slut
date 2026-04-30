using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;

    public float MoveSpeed = 5;
    public float JumpSpeed = 5;

    private SpriteRenderer spriteRenderer;

    Animator animator;

    bool isCrouching;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocityX = Input.GetAxisRaw("Horizontal") * MoveSpeed;
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            rb.linearVelocityY = JumpSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            isCrouching = true;
        }
        else
        {
            isCrouching = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.flipX = false;
        }

        HandleAnimations();
    }

    void HandleAnimations()
    {
        if (isCrouching == true)
        {
            animator.Play("MPlayer_Crouch");
            return;
        }
        else if (rb.linearVelocity.sqrMagnitude > 0)
        {
            animator.Play("MPlayer_Walk");
        }
        else if (rb.linearVelocity.sqrMagnitude > 0)
        {
            animator.Play("MPlayer_Jump");
        }
        else
        {
            animator.Play("MPlayer_Idle");
        }
    }
}
