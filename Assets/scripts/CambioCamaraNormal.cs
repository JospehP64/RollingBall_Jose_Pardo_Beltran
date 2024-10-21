using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamaraNormal : MonoBehaviour
{
    [SerializeField] GameObject CambiarACenital;
    [SerializeField] GameObject MainCamera;
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

        //CambiarACenital.SetActive(true);
        //MainCamera.SetActive(false);
        if (other.gameObject.CompareTag("Player"))
        {
            CambiarACenital.SetActive(false);
            MainCamera.SetActive(true);

        }



    }
}
