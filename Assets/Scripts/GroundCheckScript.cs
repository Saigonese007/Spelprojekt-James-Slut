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
        if (isGrounded)
        {
            Debug.Log("[1] isGrounded = true");
        }
        else if (isGrounded == false)
        {
            Debug.Log("[1] isGrounded = false");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
