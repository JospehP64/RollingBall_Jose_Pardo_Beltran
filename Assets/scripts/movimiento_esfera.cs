using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class movimiento_esfera : MonoBehaviour
{
    AudioManager audioM;
    [SerializeField]bool HasLlegadoALaMeta = false;
    [SerializeField] TextMeshProUGUI Textvida;
    [SerializeField] TextMeshProUGUI TextEnergia;
    [SerializeField] TextMeshProUGUI TextMoneda;
    [SerializeField]Canvas canvasPuntuacion;
    [SerializeField]Canvas canvasGameOver;
    [SerializeField]Canvas canvasJuego;
    [SerializeField]Canvas canvasPausa;

    [SerializeField]RawImage RI;
    

    float h;
    float v;


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
    
    public int MonedaCubo1 { get => MonedaCubo; set => MonedaCubo = value; }
    public int Vida { get => vida; set => vida = value; }


    // Start is called before the first frame update
    void Start()
    {

        canvasPausa.enabled = false;
        canvasJuego.enabled = true;
        canvasGameOver.enabled = false;
        canvasPuntuacion.enabled = false;

        HasLlegadoALaMeta = false;
        canvasPuntuacion.enabled = false;
        RI.enabled = false;
        rb = GetComponent<Rigidbody>();
        audioM = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        movimiento = new Vector3(h, 0f, v);
        if (Input.GetKeyDown(KeyCode.Escape) && canvasPausa.enabled == false && canvasPuntuacion.enabled == false)
        {
            Time.timeScale = 0;
            canvasPausa.enabled = true;
        }
        


        GameOver();

        if (HasLlegadoALaMeta == true)
        {
            canvasJuego.enabled = false;
            canvasPuntuacion.enabled = true;
            Time.timeScale = 0;
        }
        else
        {

        }

        Textvida.SetText("Vida: " + vida);
        if (energiaActivada == true)
        {
            TextEnergia.SetText("Time control: Activado");
            //TextEnergia.color = Color.green;
        }
        else
        {
            TextEnergia.SetText("Time control: Descactivado");
            //TextEnergia.color = Color.red;
        }
        
        TextMoneda.SetText("" + MonedaCubo);

        Ray raycast = new Ray(transform.position, direccion);
        
        //Debug.DrawRay(transform.position, direccion * 2, Color.red);
        //if (Physics.Raycast out impact){ }

        

        //movimiento con GetAxisRaw y translate
         

        
        
        
        


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
        
        if (Input.GetKey(KeyCode.LeftShift) && HasLlegadoALaMeta == false && canvasPausa.enabled == false)
        {
            energiaActivada = true;
            //velocidad = 10;
            Time.timeScale = 0.3f;
            rb.AddForce(new Vector3(h, 0f, v) * 2);
            RI.enabled = true;

        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) && HasLlegadoALaMeta == false && canvasPausa.enabled == false) 
        {
            energiaActivada = false;
            Time.timeScale = 1.0f;
            RI.enabled= false;

        }
        else
        {
            RI.enabled = false;
        }
        

    }
    void FixedUpdate()
    {
        velocidad = 5;
        movimiento = movimiento * velocidad;
        // transform.Translate(movimiento);
        rb.AddForce(new Vector3(h, 0f, v) * 5);
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
            transform.position = new Vector3(-96.214f, 37.416f, -60.782f);
            vida--;
        }
        if (collision.gameObject.CompareTag("flag"))
        {
            
            HasLlegadoALaMeta = true;
            
            
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("moneda"))
        {
            audioM.GetComponent<AudioSource>().Play();
            Destroy(collider.gameObject);
            
            //audioM.ReproducirSonido();
            MonedaCubo++;

        }
    }
    void GameOver()
    {
        if (vida <= 0)
        {
            audioM.GetComponent<AudioSource>().Stop();
            canvasJuego.enabled = false;
            canvasGameOver.enabled = true;
            Time.timeScale = 0;
        }    
    }
    public void reanudar()
    {
        if (canvasPuntuacion.enabled == false || canvasGameOver.enabled == false || canvasPuntuacion.enabled == false && canvasGameOver.enabled == false || canvasPausa == true)
        {
            Time.timeScale = 1;
            canvasPausa.enabled = false;
        }
        else
        {

        }
            
    }

}
