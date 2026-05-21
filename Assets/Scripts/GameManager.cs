using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public float timeLimit = 120f;
    float timeLeft;

    public int score = 0;

    public TextMeshProUGUI timeText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
   

    bool gameOver = false;

    void Awake()
    {
        instance = this; // för att andra scripts ska kunna ha denna i hela spelet
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeLeft = timeLimit; //efter denna tid så ska det blir gamover

        gameOverText.gameObject.SetActive(false); // Så att gameover inte finns i början av spelet

        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver) return;

        timeLeft -= Time.deltaTime; // så det inte blir inconsitent

        if (timeLeft <= 0)
        {
            GameOver();
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        timeText.text = "Time: " + (int)timeLeft;
        scoreText.text = "Score: " + score;
    }

    public void AddScore(int amount)
    {
        if (gameOver) return;

        score += amount;
        UpdateUI();
    }

    void GameOver()
    {
        gameOver = true;

        gameOverText.gameObject.SetActive(true);
        gameOverText.text = "Game Over";

        Time.timeScale = 0f; // stoppar spelet helt
    }
}
