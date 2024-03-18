using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Array dde enteros
    public int[] nums;
    public GameObject[] enemies;
    // Array privada indicamos el tamaño
    float[] numbers = new float[7];
    void Start()
    {
       /*
        nums[1] = 25;
        Debug.Log("El valor de la casilla 1 es: " + nums[1]);

        */
        
        for(int i=0; i < nums.Length; i++)
        {
            Debug.Log("El valor de la casilla  es: " + nums[i]);
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
