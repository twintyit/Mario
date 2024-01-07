using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artefact : MonoBehaviour
{
    public GameControll gameControll;    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerTrigger") && gameObject.tag == "Artefact")
        {            
            gameControll.UpArtefact();
            gameObject.SetActive(false);
        }
        else if (collision.CompareTag("PlayerTrigger") && gameObject.tag == "Key")
        {
            gameControll.UpKey();
            gameObject.SetActive(false);
        }
    }
}
