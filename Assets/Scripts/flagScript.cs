using UnityEngine;
using UnityEngine.SceneManagement;

public class flagScript : MonoBehaviour
{
    public string nextLevel;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.Play("flagFinish");
            Invoke("LoadNextLevel", 2f); // delay så att man väntar 

            string levelName = SceneManager.GetActiveScene().name;

            Utility.saveData[levelName] = "completed";
        }

    }
    void LoadNextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
