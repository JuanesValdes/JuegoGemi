using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVGEMI : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad=5;
    public float salto = 3;
    public float rotar = 50;
    public CamaraF rotarCamara;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * salto * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * rotar * Time.deltaTime);
        }

       if (Input.GetKey(KeyCode.E))
        {
            //transform.Rotate(Vector3.up * rotar * Time.deltaTime);
            transform.localEulerAngles = new Vector3(0, rotar, 0);
            rotarCamara.rotarCamara = true;
        }
    }
}
