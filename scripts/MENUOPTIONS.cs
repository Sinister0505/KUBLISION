
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUOPTIONS : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;  
    public static bool IsGamePaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { 

        if (IsGamePaused)
        {
            ResumeGame();

        }
        else
        {
            PauseGame();
        }
        }
    }
          public void ResumeGame()
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
            IsGamePaused = false;
        }
         public void PauseGame()

        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            IsGamePaused = true;


             
        }


    public void LoadMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");

    }
      
         
        
    
}
