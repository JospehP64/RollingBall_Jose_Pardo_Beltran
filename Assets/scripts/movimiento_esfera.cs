using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class movimiento_esfera : MonoBehaviour
{
    RaycastHit impact;
    Vector3 direccion = new Vector3(0f,-10f,0f);
    
    [SerializeField] TMP_Text score_Text;
    Rigidbody rb;
    Vector3 movimiento;
    [SerializeField] float velocidad;
    Vector3 salto = new Vector3(0f,0.5f,0f);


    public float Velocidad { get => velocidad; set => velocidad = value; }

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray raycast = new Ray(transform.position, direccion);
        
        //Debug.DrawRay(transform.position, direccion * 2, Color.red);
        //if (Physics.Raycast out impact){ }

        

        //movimiento con GetAxisRaw y translate
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        movimiento = new Vector3(h, 0f, v);
        velocidad = 3;
        movimiento =  movimiento * velocidad * Time.deltaTime;
       // transform.Translate(movimiento);
       rb.AddForce(new Vector3 (h, 0f, v));
        
        
        


        if (Input.GetKey(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, direccion, 1))
            {
                rb.AddForce(salto * 0.1f, ForceMode.Impulse);
            }
            else
            {
                
            }
            
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidad = 10 * Time.deltaTime;
        }
        else
        {
            velocidad = 1;
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
