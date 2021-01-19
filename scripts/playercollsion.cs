 
using UnityEngine;

public class playercollsion : MonoBehaviour
{
    public GameManager GameManager;
    public Playermovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }



}
