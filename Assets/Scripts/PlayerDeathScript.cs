using UnityEngine;

public class PlayerDeathScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerScript player = other.GetComponent<PlayerScript>();

            if (player != null)
            {
                player.TakeDamage();
                Debug.Log("Player DEAD");
            }
        }
    }
}
