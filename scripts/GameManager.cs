
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
    
{
    bool GameHasEnded = false;
    public float restartDelay = 1f;
   
    public  GameObject CompleteLevelUI;
    public void CompleteLevel()
    {
        
        CompleteLevelUI.SetActive(true);
        
    }
   
     
    public void EndGame()
        
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;

            Debug.Log("GAME OVER");

            Invoke("Restart", restartDelay); 
        }
    }
       public void Completelevel()
    {
        Debug.Log("LEVEL WON!");
    }
       void Restart ()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
} 

