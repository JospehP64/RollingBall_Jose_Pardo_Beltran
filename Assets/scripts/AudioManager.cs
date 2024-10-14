using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource sfx;
    

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [SerializeField] AudioSource ReproducirSonido(AudioClip Miclip)
    {
        sfx.PlayOneShot(Miclip);
        return sfx;
        
    }

    

}
