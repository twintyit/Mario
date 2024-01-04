using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip jumpSound;
    public AudioClip walkSound;
    public AudioClip enemySound;
    public AudioClip artefactSound;

    private bool isJump = false;
    private bool isEnemy = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") | collision.CompareTag("X1"))
        {
            isEnemy = true;
            audioSource.PlayOneShot(enemySound);
            isEnemy = false;
        }
        else if(collision.CompareTag("Artefact"))
        {
            audioSource.PlayOneShot(artefactSound);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            audioSource.PlayOneShot(jumpSound);
            isJump = false;
        }

        if ((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) && !isJump)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(walkSound);
            }
        }
        else if((!isEnemy || !isJump) && (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
