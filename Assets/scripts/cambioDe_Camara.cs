using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioDe_Camara : MonoBehaviour
{
    [SerializeField] GameObject CambiarACenital;
    [SerializeField] GameObject MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        CambiarACenital.SetActive(false);
        MainCamera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        CambiarACenital.SetActive(true);
        MainCamera.SetActive(false);
        //if (other.gameObject.CompareTag("Player"))
        //    {
        //    if ( MainCamera == false)
        //    {
        //        CambiarACenital.SetActive(true);
        //        MainCamera.SetActive(false);
        //    }
        //        
        //    else
        //    {
        //        CambiarACenital.SetActive(false);
         //       MainCamera.SetActive(true);
         //   }
          //  }
        
        
        
    }
}
