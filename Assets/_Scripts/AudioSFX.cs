using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSFX : MonoBehaviour
{
    public AudioSource pickUpSFX;
    public AudioSource deathSFX;

    public AudioSource mainCamera;

 
    // Update is called once per frame
    void Update()
    {
        
    }

 
    public void PlayDeathSFX()
    {
        mainCamera.Pause();
        deathSFX.Play();
    }

    public void PlayPickupSFX()
    {
        pickUpSFX.Play();
    }
}
