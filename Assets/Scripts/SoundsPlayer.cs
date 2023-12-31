using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip jumpSound;
    public AudioClip walkSound;

    private bool isJump = false;
    void Start()
    {
       
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
        else if(!isJump && (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
