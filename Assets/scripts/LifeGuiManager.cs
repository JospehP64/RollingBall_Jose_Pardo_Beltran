using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class LifeGuiManager : MonoBehaviour
{
    [SerializeField] RawImage heart_ui_component;
    [SerializeField] RawImage Second_heart_ui_component;
    [SerializeField] RawImage Third_heart_ui_component;
    [SerializeField] Texture[] heart_texture;
   RawImage imagen;
   RawImage imagen_2;
   RawImage imagen_3;
    movimiento_esfera esfera;
    
    
    // Start is called before the first frame update
    void Start()
    {
        esfera = GameObject.Find("player_sphere").GetComponent<movimiento_esfera>();
        imagen = (RawImage)heart_ui_component.GetComponent<RawImage>();
        imagen_2 = (RawImage)Second_heart_ui_component.GetComponent<RawImage>();
        imagen_3 = (RawImage)Third_heart_ui_component.GetComponent<RawImage>();
        imagen.texture = (Texture)heart_texture[0];
        imagen_2.texture = (Texture)heart_texture[0];
        imagen_3.texture = (Texture)heart_texture[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        if (esfera.Vida >= 3)
        {
            imagen.texture = (Texture)heart_texture[0];
            imagen_2.texture = (Texture)heart_texture[0];
            imagen_3.texture = (Texture)heart_texture[0];
        }
        else if (esfera.Vida >= 2 && esfera.Vida < 3)
        {
            imagen.texture = (Texture)heart_texture[1];
            imagen_2.texture = (Texture)heart_texture[0];
            imagen_3.texture = (Texture)heart_texture[0];
        }
        else if (esfera.Vida >= 1 && esfera.Vida < 2)
        {
            imagen.texture = (Texture)heart_texture[1];
            imagen_2.texture = (Texture)heart_texture[1];
            imagen_3.texture = (Texture)heart_texture[0];
        }
        else if (esfera.Vida <= 0)
        {
            imagen.texture = (Texture)heart_texture[1];
            imagen_2.texture = (Texture)heart_texture[1];
            imagen_3.texture = (Texture)heart_texture[1];
        }
    }

    void LifeArray()
    {
       


    }
}
