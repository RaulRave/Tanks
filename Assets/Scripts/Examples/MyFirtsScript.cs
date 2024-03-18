using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirtsScript : MonoBehaviour
{
    // variable vida
    int life;

    int power;

    float jumpForce;

    string namePlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        MyFunction(); // Llamada a la funcion   
        
        // Damos valor a una variable
      life = 5;

      power = 2;

      Debug.Log("El valor de la vida del personaje es: " + life); 

        CalculateNumber();

      // Sacar los mensaje por consola Unity    

     

      jumpForce = 50.5f;

      Debug.Log("El valor de la fuerza del personaje es: " + jumpForce); 

      namePlayer = "Raul";

      Debug.Log("El valor de la fuerza del personaje es: " + namePlayer);


    }

    // Declaraciion de la funcion/metodo
    void MyFunction()
    {
        Debug.Log("Esta es mi priimera funcion");
    }

    void CalculateNumber()
    {
        life = life * power;

        Debug.Log("El valor de la vida del personaje es: " + life);
    }

    // Update is called once per frame los botones donde el jugador pulsara 
    void Update()
    {
        
    }
}

