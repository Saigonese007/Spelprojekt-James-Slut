using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLevelScript : MonoBehaviour
{
    public string sceneToLoad;

    public Sprite completedSprite;

    Image img;

    private void Start()
    {

        img = GetComponent<Image>();

        if (Utility.saveData.ContainsKey(sceneToLoad) && // kollar om den har sparat något på den leveln
            Utility.saveData[sceneToLoad] == "completed") // är den completed
        {
            img.sprite = completedSprite; // om båda är true, då byt bild till complete
        }
    }
    public void ChooseLevel()
    {
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log($"{sceneToLoad} Loaded");
    }
}
