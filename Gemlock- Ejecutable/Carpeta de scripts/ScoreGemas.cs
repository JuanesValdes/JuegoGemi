using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Gemlock
//Juan Carlos Valdés Aguilar
//Estructura de datos
//Script de score separado al normal, este es para las gemas obtenidas

public class ScoreGemas : MonoBehaviour
{
    //Hacer que el objeto de gemas se destruyan cuando entra en contacto con el jugador y nos añada puntos a nuestro score total
    public static int scoregemas;
    Text text;

    // Use this for initialization
    void Start()
    {

        text = GetComponent<Text>();
        scoregemas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (scoregemas < 0)
            scoregemas = 0;
        text.text = "" + scoregemas;

    }
    public static void AddPoints(int pointsToAdd)
    {
        scoregemas += pointsToAdd;
    }
    public static void Reset()
    {
        scoregemas = 0;
    }
}