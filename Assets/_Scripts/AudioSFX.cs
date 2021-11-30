using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSFX : MonoBehaviour
{
    public AudioSource pickUpSFX;
    public AudioSource deathSFX;

 
    // Update is called once per frame
    void Update()
    {
        
    }

 
    public void PlayDeathSFX()
    {
        deathSFX.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        pickUpSFX.Play();
    }
}
