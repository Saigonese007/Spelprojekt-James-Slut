using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public float timeLimit = 120f;
    float timeLeft;

    public int score = 0;

    public TextMeshProUGUI timeText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button RestartAfterDeathButton;


    public PlayerScript player;


    bool gameOver = false;

    void Awake()
    {
        instance = this; // för att andra scripts ska kunna ha denna i hela spelet
    }
    void Start()
    {
        timeLeft = timeLimit; //efter denna tid så ska det blir gamover
        RestartAfterDeathButton.gameObject.SetActive(false); // samma som gameover text
        gameOverText.gameObject.SetActive(false); // Så att gameover inte finns i början av spelet
          
        UpdateUI();
    }

    void Update()
    {

        if (gameOver) return;

        timeLeft -= Time.deltaTime; // så det inte blir inconsistent

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

    
    public void GameOver()
    {

       if (gameOver) return;

        gameOver = true;

        gameOverText.gameObject.SetActive(true);
        gameOverText.text = "Game Over";

        RestartAfterDeathButton.gameObject.SetActive(true);


        Time.timeScale = 0f; // stoppar spelet helt
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
