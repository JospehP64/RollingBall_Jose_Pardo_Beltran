using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movimiento_plataforma : MonoBehaviour
{
    [SerializeField] float velocidad = 1;
    [SerializeField] Vector3 direccion = new Vector3(-2.14f, 0, -0);
    float Timer = 0;
    float velRota = 0;
    Vector3 dirRota = new Vector3(0.65f, 432.57f, 180.769f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(direccion * velocidad * Time.deltaTime);
        transform.Rotate(dirRota * velRota * Time.deltaTime, Space.World);
        Timer += 1 * Time.deltaTime;
        if (Timer >= 3)
        {
            direccion *= -1f;
        }
    }
    void rotate()
    {
        

    }
    
}
