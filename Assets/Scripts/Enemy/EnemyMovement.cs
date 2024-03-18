using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // Para acceder al componente Nav Mesh Agent

public class EnemyMovement : MonoBehaviour
    // con la IA haremos que el enemigo nos persiga  en el gameobejt tank enemy le ponemos Nav Mesh Agent y ampliamos el radius 
{
    Transform target;// cual es el jugador enemigo

    NavMeshAgent agent; // para acceder siempre creamos la variable

    void Start()
    {
        //buscamos entre todos los gameobject que tengaa la etiqueta player cogiendo su transfor y guardandolo en la variable target
        target = GameObject.FindGameObjectWithTag("Player").transform;
        // la variable accede al componente
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        //Si target es distinto de null te metes
        if(target!=null)
        // el enemeigo buscara la posicion del jugador
             agent.SetDestination(target.position);
    }
}

// en tank enemy ponomes el script y en targer el tankplayer y actualizamos el prefab del enemigo
// tank enemy overrides a aplly all y eliminamos el tank enemy
// en player ponemos el tag player