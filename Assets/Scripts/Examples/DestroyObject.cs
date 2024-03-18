using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float time;
    // Metodo que se invoca de forrma auto cuando hacemos click boton izquirdo raton sobre 
    //un gameobjet que tiene un collider
    private void OnMouseDown()
    {
        /*
          Debug.Log("Destruimos el objeto");
          Destroy(gameObject);
        */

        //Destruimos con tiempo
        Debug.Log("Destruimos el objeto en 3 segundos");
        Destroy(gameObject, time);

    }

}

