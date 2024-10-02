using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_esfera : MonoBehaviour
{
    Vector3 direccion;
    float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.position = new Vector3 (1, 0, 0);
        movimiento();
        
    }
    void movimiento()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3 (0,0,-1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, 1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0 * Time.deltaTime);
        }
        
    }
}
