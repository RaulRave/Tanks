using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Va hacer referencia al prefab de la "bala" que esta en ASSETS
    public GameObject ballPrefab;
    public Transform positionBall; // posicion de salida de la bala
    public float forceBall; // Indicar la fuerza de la bola
    public float timeBetweenAttacks; // Indicamos que el disparo tenga un tiempo o latencia de disparo

    AudioSource audioS;// añadir sonido
    float timer; // controlamos que no pueda atacar si no ha pasado el tiempo 
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    void Attack()
    {
        timer += Time.deltaTime; // Contador de tiempo
        // timer = timer + Time.deltaTime;

        // Si pulso el boton Izquierdo Raton ataca y con el timer es igual o mayor al timebe ataca y resetea al timer a 0
        if (Input.GetMouseButtonDown(0) && timer >= timeBetweenAttacks)
        {

            timer = 0;
            CreateCloneBall(); // llamo al boton create ball
        }
    }

    void CreateCloneBall()
    {

        audioS.Play();

        // creamos una variable local  cloneball y es igual a la bola del prefeb original
       GameObject cloneball =  Instantiate(ballPrefab, positionBall.position, positionBall.rotation);

        // Forma mas optimo
        Rigidbody rbCloneBall = cloneball.GetComponent<Rigidbody>();
        rbCloneBall.AddForce(Vector3.up * forceBall / 2);
        rbCloneBall.AddForce(transform.forward * forceBall);


        // Destruimos la bala para que desaparezcan
        Destroy(cloneball, 5);


        /* guardamos el componente al rigidbody para añadirle fuerza para arriba
        cloneball.GetComponent<Rigidbody>().AddForce(Vector3.up * forceBall/2);
        // añadirle fuerza para adelante
        cloneball.GetComponent<Rigidbody>().AddForce(transform.forward * forceBall);
        */
    }
}
