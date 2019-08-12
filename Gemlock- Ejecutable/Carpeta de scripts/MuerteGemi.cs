using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Gemlock
//Juan Carlos Valdés Aguilar
//Estructura de datos
//Script de muerte del player

public class MuerteGemi : MonoBehaviour
{

    //Define la muerte de "gemi" cada que toca a un enemigo, no sólo destruyendo el modelo si no también reiniciando la escena
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Saquief")
        {
            
            Destroy(gameObject);
            Debug.Log("DEATH");
            SceneManager.LoadScene(0);
        }



    }
}