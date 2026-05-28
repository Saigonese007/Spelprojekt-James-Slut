using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{
    public string sceneToLoad;

        public void ChooseLevel()
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    
}



