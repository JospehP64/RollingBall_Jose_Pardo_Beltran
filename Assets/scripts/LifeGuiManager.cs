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
    movimiento_esfera esfera;
    // Start is called before the first frame update
    void Start()
    {
        heart_ui_component = GetComponent<RawImage>();
        
        heart_ui_component.texture = (heart_texture[0])as Texture;

    }

    // Update is called once per frame
    void Update()
    {
        LifeArray();
    }

    void LifeArray()
    {

        if (esfera.Vida >= 3)
        {
            heart_ui_component.texture = heart_texture[0];
            Second_heart_ui_component.texture = heart_texture[0];
            Third_heart_ui_component.texture = heart_texture[0];
        }
        else if (esfera.Vida >= 2 && esfera.Vida < 3)
        {
            heart_ui_component.texture = heart_texture[2];
            Second_heart_ui_component.texture = heart_texture[1];
            Third_heart_ui_component.texture = heart_texture[1];
        }
        else if (esfera.Vida >= 1 && esfera.Vida < 2)
        {
            heart_ui_component.texture = heart_texture[1];
            Second_heart_ui_component.texture = heart_texture[1];
            Third_heart_ui_component.texture = heart_texture[0];
        }
        else if (esfera.Vida <= 0)
        {
            heart_ui_component.texture = heart_texture[1];
            Second_heart_ui_component.texture = heart_texture[1];
            Third_heart_ui_component.texture = heart_texture[1];
        }

    }
}
