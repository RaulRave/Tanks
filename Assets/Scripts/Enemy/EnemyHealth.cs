using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        // busca el componente gamemager con la etiqueda game coontoller
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }
    // Cuando se produce la colicion  con que esta chocando

    /* private void OnCollisionEnter(Collision collision)
     {
         // nos da informacion de la colicion con el colaider en la etiqueda creada
        if(collision.collider.CompareTag("Ball"))
         {

             Destroy(collision.gameObject); // Destruyo la bala
             Destroy(gameObject); // Destruyo al enemigo


         }

             // comprabamos que nos de el mensaje que hay colicion
            // Debug.Log("La bollla ha chocado conmigo (enemigo)");
     }*/


    // Se suele usar mejor esto con un ontrigger


    //en el prefab de ball marcamos sphere collaider es un triger 
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            Destroy(other.gameObject); // Destruyo la bala
            DeathEnemy();
            
        }
    }

    void DeathEnemy()
    {
        Destroy(gameObject); // Destruyo al enemigo
        gameManager.AddEnemy();// Llamo aa la funcion que esta en el script GameManager para que muestre el numero de enemigos destruidos
        //
    }

}
