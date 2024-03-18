using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamara : MonoBehaviour
{
    // Seguir al objeto con la camara
    public GameObject tank;
    public Transform tankTransform;
    void Start()
    {
        
    }

    // mira al jugador
    void Update()
    {
        if(tankTransform!=null)
            transform.LookAt(tankTransform);
    }
}
