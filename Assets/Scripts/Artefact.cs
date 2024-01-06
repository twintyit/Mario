using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artefact : MonoBehaviour
{
    public GameControll gameControll;
    private bool collisionHandled = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerTrigger"))
        {
            gameObject.SetActive(false);
            gameControll.UpArtefact();
        }
    }
}
