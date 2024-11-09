using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
 //A veces, public puede ser útil. Usa public solo para algunos métodos; y usa [SerializedField] solo para las variables 
    public void jugar()
    {
        SceneManager.LoadScene(1);
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Controles()
    {
        SceneManager.LoadScene(2);
    }
    public void Menu_principal()
    {
        SceneManager.LoadScene(0);
    }
}
