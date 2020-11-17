using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
       SceneManager.LoadScene("level_1");      
        
    }

    public void QuitGame()
    {
       
        Application.Quit();
    }
}
