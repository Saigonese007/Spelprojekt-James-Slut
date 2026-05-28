using UnityEngine;

public class HeadHit : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("LuckyBlockBottom"))
        {
            LuckyBlockScript block = other.GetComponentInParent<LuckyBlockScript>();

            block.HitBlock();


            Debug.Log("LB hit");
        }
    }
}
