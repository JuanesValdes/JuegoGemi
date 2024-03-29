﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Gemlock
//Juan Carlos Valdés Aguilar
//Estructura de datos
//Script de score

public class Score : MonoBehaviour
{
    //Sistema de score, con el cual se irá actualizando de la mano con cada objeto que el player obtenga, aumentando el puntaje determinado en cada obj
    public static int score;
    Text text;

    // Use this for initialization
    void Start()
    {

        text = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (score < 0)
            score = 0;
        text.text = "" + score;

    }
    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }
    public static void Reset()
    {
        score = 0;
    }
}