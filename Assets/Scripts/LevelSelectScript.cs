using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{
    public string sceneToLoad;
    public void ChooseLevel()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }



}



