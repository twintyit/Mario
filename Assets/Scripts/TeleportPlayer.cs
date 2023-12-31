using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform teleportDestination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("X1") | collision.CompareTag("Enemy"))
        {
            transform.position = teleportDestination.position;                     
        }
    }  
}
