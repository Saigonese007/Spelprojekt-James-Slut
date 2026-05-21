using UnityEngine;

public class LuckyBlockScript : MonoBehaviour
{

    SpriteRenderer sr;

    bool used = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
          
        }
    }
}
