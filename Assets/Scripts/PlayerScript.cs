using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;

    public float MoveSpeed = 5;
    public float JumpSpeed = 5;

    SpriteRenderer spriteRenderer;

    GroundCheckScript GroundCheck;

    Animator animator;

    bool isCrouching;

    AudioSource aSource;
    public AudioClip[] SoundEffects;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        aSource = GetComponent<AudioSource>();
        GroundCheck = GetComponentInChildren<GroundCheckScript>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocityX = Input.GetAxisRaw("Horizontal") * MoveSpeed;
        if (Input.GetKeyDown(KeyCode.Space) == true && GroundCheck.isGrounded)
        {
            rb.linearVelocityY = JumpSpeed;
            aSource.PlayOneShot(SoundEffects[0]);
        }


        /* har inte gjort denna än
        if (Input.GetKey(KeyCode.S))
        {
            isCrouching = true;
        }
        else
        {
            isCrouching = false;
        }
        */

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
        else if (!GroundCheck.isGrounded)
        {
            animator.Play("MPlayer_Jump");
            return;
        }
        else if (Input.GetAxisRaw("Horizontal") != 0)
        {
            animator.Play("MPlayer_Walk");
            return;
        }
        else
        {
            animator.Play("MPlayer_Idle");
        }
    }
}
