using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class movimiento_esfera : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Textvida;
    [SerializeField] TextMeshProUGUI TextEnergia;
    [SerializeField] TextMeshProUGUI TextMoneda;
    [SerializeField]RawImage RI;

    int vida = 3;
    bool energiaActivada = false;

    
    int MonedaCubo = 0;

    AudioManager Manager;
    AudioClip Miclip;
    float raycastSize = 0.21f;
    RaycastHit impact;
    Vector3 direccion = new Vector3(0f,-10f,0f);
    
    
    Rigidbody rb;
    Vector3 movimiento;
    [SerializeField] float velocidad;
    Vector3 salto = new Vector3(0f,0.5f,0f);


    public float Velocidad { get => velocidad; set => velocidad = value; }
    

    // Start is called before the first frame update
    void Start()
    {
        RI.enabled = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Textvida.SetText("Vida: " + vida);
        if (energiaActivada == true)
        {
            TextEnergia.SetText("Time control: Activado");
            TextEnergia.color = Color.green;
        }
        else
        {
            TextEnergia.SetText("Time control: Descactivado");
            TextEnergia.color = Color.red;
        }
        
        TextMoneda.SetText("Monedas Cubo: " + MonedaCubo);

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
        
        
        


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, direccion, raycastSize))
            {
                rb.AddForce(salto * 10f, ForceMode.Impulse);
            }
            else
            {
                
            }
            
        }
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            energiaActivada = true;
            //velocidad = 10;
            Time.timeScale = 0.3f;
            RI.enabled = true;

        }
        else
        {
            energiaActivada = false;
            Time.timeScale = 1.0f;
            RI.enabled= false;

        }
        

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("moneda"))
        //{
        //    Destroy(collision.gameObject);
            //score_Text = Set.
            

            
        //}
        //Nota: en el caso de las monedas, si se quiere atravesar las monedas y al mismo tiempo tocarlas, usar un "OntriggerEnter" en su lugar
        if (collision.gameObject.CompareTag("CLateral"))
        {

        }
        if (collision.gameObject.CompareTag("vacio"))
        {
            transform.position = new Vector3(-96.296f, 37.356f, -58.89f);
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("moneda"))
        {
            Destroy(collider.gameObject);
            MonedaCubo++;
        }
    }


}
