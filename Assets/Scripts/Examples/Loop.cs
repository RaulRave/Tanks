using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // variables globales, que puede ser usadas dentro de cual quier parte en la clase
    // Podemos usarlas en cualquien funcion o metodo
    public int speed;
    public int num;

    float xPosition;
    float yPosition;
    

    //Start se repite solo 1 vez 
    void Start()
    {
        //Variable local que se declara dentro de una funcioin y solo puede ser usada
        // dentro de esa funcion
        float force = 30;

        Debug.Log("La fuerza es: " + force);

        Debug.Log("La velocidad es: " + speed);


        //Leyendo el valor de la posicion del game option del tanque
        xPosition = transform.position.x;
        yPosition = transform.position.y;
        Debug.Log("La posiciion es x es: " + xPosition);
        Debug.Log("La posiciion es y es: " + yPosition);

        //Asignar un valor a la posicion

        //transform.position = new Vector3(5, transform.position.y, transform.position.z);


        /*
         Condicion IF ELSE IF ELSE
         Si cumple pasa una cosa

        No se cumple pasa otra cosa

        > Mayo que
        < Menor que
        == igual que
        >= Mayor o igual que
        <= Menor o igual que
        && Y
        || O
        
         */



        /*
         Bucle For para una accion que vamos a repetir una determinada de veces que pongamos
        ++ SUMAR 1
        -- RESTAR 1
         */

        for(int i=0; i <6; i++)
        {
            num = num + i;
            Debug.Log("El valor de i es: " + i);
        }

        
    }

    void CalculateNumber()
    {
        speed = 9;
        
    }

    // Update se repite el codigo muchas veces por frame
    void Update()
    {
        if (xPosition > 5)
        {
            Debug.Log("La posision del tanque en X es mayor que 5");
        }
        else if(xPosition <=5 && xPosition >=3)
        {
            Debug.Log("La posision del tanque en X es menor e igual que 5 pero mayor e igual que 3");
        }
        else
        {
            Debug.Log("La posision del tanque en X es menor que 3");
        }
        

    }
}
