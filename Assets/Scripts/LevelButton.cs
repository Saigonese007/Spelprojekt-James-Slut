using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    public string levelName;
    public Sprite completedSprite;

    Image img;
 
    void Start()
    {
        img = GetComponent<Image>();

        if (Utility.saveData.ContainsKey(levelName)) // kolla savedata
        {
            if (Utility.saveData[levelName] == "completed")  // checka om lvl är completed
            {
                img.sprite = completedSprite; // byt bild 
            }
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelName);
    }
}
