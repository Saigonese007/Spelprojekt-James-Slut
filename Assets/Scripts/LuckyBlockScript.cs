using UnityEngine;

public class LuckyBlockScript : MonoBehaviour
{

    SpriteRenderer sr;

    public Sprite usedSprite;


    public int scoreAdded = 5;

    bool used = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        
    }


    public void HitBlock()
    {
        if (used) return;

        used = true; // sätter så att den är used

        sr.sprite = usedSprite; // ändrar till en annat used block

        GameManager.instance.AddScore(scoreAdded);
    }
}
