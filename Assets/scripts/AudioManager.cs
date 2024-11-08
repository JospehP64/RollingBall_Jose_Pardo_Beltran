using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource sfx;

    public AudioSource Sfx { get => sfx; set => sfx = value; }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReproducirSonido(AudioClip Miclip)
    {
        sfx.PlayOneShot(Miclip);
        
    }

    

}
