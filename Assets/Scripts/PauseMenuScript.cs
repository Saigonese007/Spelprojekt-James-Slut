using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{

    public static bool paused = false; 

    public GameObject pauseMenu;

    private void Start()
    {
        pauseMenu.SetActive(false); // gömmer pause menu första den gör när man startar spelet
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // menu pops up om player trycker esc
        {
            Debug.Log("Pause Menu Check");
            TogglePause();
        }
    }

    void TogglePause()
    {
        paused = !paused; // inverterar värdet

        pauseMenu.SetActive(paused); // visar menu om paused = true, gömmer om false

        if (paused)
        {
            Time.timeScale = 0f; // stoppar spelet helt
        }
        else
        {
            Time.timeScale = 1f; // startar spelet igen
        }
    }

    public void ResumeGame()
    {
        paused = false; // säger att spelet inte längre är pausat

        pauseMenu.SetActive(false); // gömmer pause menu

        Time.timeScale = 1f; //går tillbaka till vanligt
    }

    public void RetryLevel()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // laddar om nuvarande level
    }

    public void GoToLevelSelect()
    {
        Time.timeScale = 1f; // går tillbaka till vanligt

        SceneManager.LoadScene("LevelSelect"); // skickar spelaren till level select scenen
    }

    public void QuitToMainMenu()
    {
        Time.timeScale = 1f; // går tillbaka till vanligt

        SceneManager.LoadScene("MainMenu"); // går till huvudmenyn
    }
}
