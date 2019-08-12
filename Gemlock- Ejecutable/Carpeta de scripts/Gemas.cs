using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gemlock
//Juan Carlos Valdés Aguilar
//Estructura de datos
//Script de puntos con gemas

public class Gemas : MonoBehaviour
{
    public int pointsToAdd;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "gemi")
        {
            ScoreGemas.AddPoints(pointsToAdd);
            Destroy(gameObject);
            Debug.Log(pointsToAdd);
        }



    }
}