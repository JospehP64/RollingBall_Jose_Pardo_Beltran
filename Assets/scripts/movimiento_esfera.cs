using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class movimiento_esfera : MonoBehaviour
{
    [SerializeField] TMP_Text score_Text;
    Rigidbody rb;
    Vector3 direccion;
    float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float v = Input.GetAxisRaw("Vertical") * Time.deltaTime;
        float Movh = h * velocidad;
        rb.velocity = new Vector2(Movh, rb.velocity.x);
        
        


        if (Input.GetKey(KeyCode.Space))
        {
            
            rb.AddForce(0,1,0 * 5, ForceMode.Force);
        }
        //transform.position = new Vector3 (1, 0, 0);
        //movimiento();

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("moneda"))
        {
            Destroy(collision.gameObject);
            //score_Text = Set.
        }
    }
}
