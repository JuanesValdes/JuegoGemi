using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemigoIA
{
    Patrulla,
    Perseguir,
    Atacar
}

public class MovPuntosENEMIGO : MonoBehaviour
{
    public float velocidad;
    public Transform Saquief;
    public Transform[] puntos;
    public Transform target;
    public int indiceTarget;
    public Transform player;
    public EnemigoIA estadoActual = new EnemigoIA();

    // Start is called before the first frame update
    void Start()
    {
        estadoActual = EnemigoIA.Patrulla;
        target = puntos[1];
        Saquief.position = target.position;
        velocidad = velocidad * Time.deltaTime;
        indiceTarget = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - Saquief.position;

        float distance = Vector3.Distance(Saquief.position, target.position);
        float distancePlayer = Vector3.Distance(Saquief.position, player.position);

        Saquief.Translate(dir.normalized * velocidad, Space.World);

        if (estadoActual == EnemigoIA.Patrulla)

            target = puntos[indiceTarget];

        if (distance <= 0.5f)
        {
            if (indiceTarget >= puntos.Length - 0.5)
            {
                indiceTarget = 0;
                target = puntos[indiceTarget];
            }

            indiceTarget++;
            target = puntos[indiceTarget];


        }

        if (distancePlayer <= 0.5)
        {
            estadoActual = EnemigoIA.Perseguir;
        }

        else if (distancePlayer > 1)
        {
            estadoActual = EnemigoIA.Patrulla;
        }

        if (estadoActual == EnemigoIA.Perseguir)
        {
            target = player;
        }
    }
}