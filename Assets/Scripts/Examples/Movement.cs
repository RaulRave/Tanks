using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // mover, creamos la variable publica velocidad

    public int speed;
    public int turnSpeed;

     void Awake() /*
                   Se ejecuta una vez como el star pero primero
                    Referencia a los componentes que se llaman
                   */

    {
       // Debug.Log("Awake");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update " + Time.deltaTime);
        /*
        Vector3.forward = (0,0,1) -> eje Z
        Vector3.up= (0,1,0) -> eje Y
        Vector3.rigth= (1,0,0) -> eje X
        Time.deltaTime es el timepo entre updates y se para pasar a metros por segundo la velocidad
         */
        // Con los axis de unity projet settins
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * vertical);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontal);



        // Mover mediante pulsado teclas 

        /* if(Input.GetKey(KeyCode.W))
         {
             transform.Translate(Vector3.forward * speed * Time.deltaTime); // Moverse a la adelante
         }

         else if (Input.GetKey(KeyCode.S))
         {
             transform.Translate(-Vector3.forward * speed * Time.deltaTime); // Moverse a la atras
         }



         if (Input.GetKey(KeyCode.D))
         {
             transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime); // Rotar Izquierda
         }

         else if (Input.GetKey(KeyCode.A))
         {
             transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime); // Rotar Derecha
         }
        */

    }

     void FixedUpdate() /*
                         update espacial tiene tiempo fijo entre llamada 
                        Si no usamos el FixedUdate las fisicas del personaje al mover un objetova  a tronpicones
                         */
    {
        Debug.Log("FixedUpdate " + Time.deltaTime);
    }
}
        

