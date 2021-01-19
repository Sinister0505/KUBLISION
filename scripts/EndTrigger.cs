
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager Game;

      void OnTriggerEnter ()
    {
        Debug.Log("Trigger call is working");
        Game.CompleteLevel();
    }
}
