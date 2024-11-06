using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LifeGuiManager : MonoBehaviour
{
    [SerializeField] RawImage heart_ui_component;
    [SerializeField] RawImage Second_heart_ui_component;
    [SerializeField] RawImage Third_heart_ui_component;
    movimiento_esfera esfera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (esfera.Vida >= 3)
        {
            //heart_ui_component.CORREGIR
        }
        else if (esfera.Vida >= 2 && esfera.Vida < 3)
        {

        }
        else if (esfera.Vida >= 1 && esfera.Vida < 2)
        {

        }
        else if (esfera.Vida <= 0 )
        {

        }
    }
}
