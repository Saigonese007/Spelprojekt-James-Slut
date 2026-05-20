using UnityEngine;

public class GroundCheckScript : MonoBehaviour
{
    public bool isGrounded = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") || collision.CompareTag("Pipe") || collision.CompareTag("Enemy"))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") || collision.CompareTag("Pipe")|| collision.CompareTag("Enemy"))
        {
            isGrounded = false;
        }
    }
}
