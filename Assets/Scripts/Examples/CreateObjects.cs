using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    // Creamos un objeto para que salga cuando pulsemos una tecla 
    public GameObject spherePrefab;
    public Transform posRotSphere;
    public float time;
    public float secons;

    void Start()
    {
        //Invocarlo un metodo en un determinado tiempo
        // Invoke("CreateSphere", time);

        //Invocar un metodo para que salga cada x sugundos o tiempo
        //InvokeRepeating("CreateSphere", time, secons); //Primero el tiempo en que apareza y luego cada tiempo que vuelve a salir
    }

    // Update is called once per frame
    void Update()
    {
        //Creamos objetos pulsado una tecla
        /*
        if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(spherePrefab, posRotSphere.position, posRotSphere.rotation);
        }
        */

        //Sin pulsar nada
        if (Input.GetKeyDown(KeyCode.T))
        {
            CreateSphere();
        }
    }

    //Creamos un metodo para que aparezcan objetos automaticos
    void CreateSphere()
    {
        Instantiate(spherePrefab, posRotSphere.position, posRotSphere.rotation);
    }
}
