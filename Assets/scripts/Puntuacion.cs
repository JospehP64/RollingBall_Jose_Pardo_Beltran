using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    float PuntuacionFinal;
    movimiento_esfera esfera;
    [SerializeField] TextMeshProUGUI ScoreVida;
    [SerializeField] TextMeshProUGUI Scoregold;
    [SerializeField] TextMeshProUGUI ScoreScore;
    [SerializeField] TextMeshProUGUI RankText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreVida.SetText("Puntos de vida restantes: " + esfera.Vida);
        Scoregold.SetText("Monedas recolectadas: " + esfera.MonedaCubo1);
        ScoreVida.SetText("Puntos de vida restantes: " + esfera.Vida);
        PuntuacionFinal = esfera.MonedaCubo1 * esfera.Vida;
        ScoreScore.SetText("Puntuación total" + PuntuacionFinal);
         if (PuntuacionFinal > 70 && PuntuacionFinal <= 100 || PuntuacionFinal >= 100)
        {
            RankText.color = Color.yellow;
            RankText.SetText("S");
        }
         else if (PuntuacionFinal > 50 && PuntuacionFinal <= 70)
        {
            RankText.color = Color.white;
            RankText.SetText("A");
        }
        else if (PuntuacionFinal > 20 && PuntuacionFinal <= 50)
        {
            RankText.color = Color.cyan;
            RankText.SetText("B");
        }
        else if (PuntuacionFinal > 0 && PuntuacionFinal <= 20)
        {
            RankText.SetText("C");
            RankText.color = Color.green;
        }
        else
        {
            RankText.SetText("F");
            RankText.color = Color.red;
        }
    }
}
