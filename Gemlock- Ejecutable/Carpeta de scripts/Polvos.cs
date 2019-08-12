using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Gemlock
//Juan Carlos Valdés Aguilar
//Estructura de datos
//Script de puntos a base de polvos

public class Polvos : MonoBehaviour
{
    public int pointsToAdd;

    //Hacer que el objeto de polvos de diamante se destruya cuando entra en contacto con el jugador y nos añada puntos a nuestro score total
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="gemi")
        {
            Score.AddPoints(pointsToAdd);
            Destroy(gameObject);
            Debug.Log(pointsToAdd);
        }
        


    }
}