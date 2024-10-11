using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class movimiento_esfera : MonoBehaviour
{
    [SerializeField] TMP_Text score_Text;
    Rigidbody rb;
    Vector3 movimiento;
    [SerializeField] float velocidad;
    Vector3 salto = new Vector3(0f,1,0f);

    public float Velocidad { get => velocidad; set => velocidad = value; }

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento con GetAxisRaw y translate
       float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        movimiento = new Vector3(h, 0f, v);
        movimiento =  movimiento * velocidad * Time.deltaTime;
        transform.Translate(movimiento);
        
        


        if (Input.GetKey(KeyCode.Space))
        {
            
            rb.AddForce(salto * 0.1f , ForceMode.Impulse);
        }
        

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("moneda"))
        {
            Destroy(collision.gameObject);
            //score_Text = Set.
        }
        if (collision.gameObject.CompareTag("CLateral"))
        {

        }
    }
}
