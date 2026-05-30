using UnityEngine;
using UnityEngine.InputSystem;

public class Goomba : MonoBehaviour
{
    public float speed = 2f;

    Rigidbody2D rb;
    SpriteRenderer sr;
    Animator anim;
    BoxCollider2D bc;

    bool dead = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        bc = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocityY);
        }

    }

    void Flip()
    {
        speed *= -1;

        sr.flipX = !sr.flipX;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (dead) return;

        if (other.CompareTag("Pipe"))
        {
            Flip();
        }

        if (other.CompareTag("Stomp"))
        {
            Die();

        }
    }


    void Die()
    {
        dead = true;
        GameManager.instance.AddScore(1);
        anim.Play("Goomba_Dead");
        Debug.Log("Goomba eliminated");
    }
}
