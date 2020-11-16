using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmange : MonoBehaviour
{
    public void Nextlevel(string nameLv)
    {
        SceneManager.LoadScene(nameLv);
    }
    
    public void BacktoMenu()
    {
        SceneManager.LoadScene("選單");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
