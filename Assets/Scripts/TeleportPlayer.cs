using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform teleportDestination;
    public GameControll gameControll;   
    private bool collisionHandled = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collisionHandled)
        {
            if (collision.CompareTag("X1") || collision.CompareTag("Enemy"))
            {
                if (gameControll.Life > 0)
                {
                    collisionHandled = true;
                    transform.position = teleportDestination.position;
                    gameControll.TakeLife();
                }
                
            }            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {       
        collisionHandled = false;
    }
}
