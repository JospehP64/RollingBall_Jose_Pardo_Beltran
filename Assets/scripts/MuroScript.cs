using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroScript : MonoBehaviour
{
    [SerializeField] Rigidbody[] rb;
    float tiempoDestruyeMuros;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Time.timeScale = 0.1f;
            tiempoDestruyeMuros = 0.1f;
        }
    }
}
