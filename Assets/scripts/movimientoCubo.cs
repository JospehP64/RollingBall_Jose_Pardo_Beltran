using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCubo : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad = 1;
    [SerializeField] Vector3 direccion = new Vector3(0, 0, 0);
    float Timer = 0;
    float velRota = 0;
   // Vector3 dirRota = new Vector3(0.65f, 432.57f, 180.769f);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //transform.eulerAngles = new Vector3(0f, 1f, 0f) * 10 * Time.deltaTime;
       rb.AddTorque(new Vector3 (0, 1, 0)* 3, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.Rotate = new Vector3(0f, 1f, 0f) * 200 * Time.deltaTime;
        
    }
}
