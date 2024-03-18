using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables publicas para el movimiento y rotacion
    public int speed;
    public int turnSpeed;

    float h;
    float v;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputPlayer();
        Movement();
    }

    void InputPlayer()
    {
         h = Input.GetAxis("Horizontal");
         v = Input.GetAxis("Vertical");
    }

    void Movement()
    {
        
        //direccion movimiento eje z hacia delante * v * speed * time
        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);
        // Rootar para girar por grados
        transform.Rotate(Vector3.up * h * turnSpeed * Time.deltaTime);

    }
}
