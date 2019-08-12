using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Gemlock
//Juan Carlos Valdés Aguilar
//Estructura de datos
//Script de fin del juego

public class Fin : MonoBehaviour
{

    //Al igual que con los otros scripts de colision, el objetivo esque una vez que el jugador llegue a este collider, se termine el juego.
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "gemi")
        {

            Destroy(gameObject);
            Debug.Log("FIN");
            //SceneManager.LoadScene(0);
        }



    }
}