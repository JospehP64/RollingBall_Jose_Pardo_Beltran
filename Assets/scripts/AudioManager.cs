using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    bool MuteSound = false;
    bool MuteMusic;
    public AudioSource sfx;

    public AudioSource Sfx { get => sfx; set => sfx = value; }




    // Start is called before the first frame update
    void Start()
    {
        sfx.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReproducirSonido(AudioClip Miclip)
    {
        
            sfx.PlayOneShot(Miclip);
        
        
        
        
    }
    public void MutearSonido()
    {
        
        if (sfx.gameObject.activeSelf)
        {
            sfx.gameObject.SetActive(false);
        }
        else
        {
            sfx.gameObject.SetActive(true);
        }

    }

    

}
