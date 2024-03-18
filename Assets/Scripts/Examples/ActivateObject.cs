using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lightTank;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Manera limpia y desactivar y activar con un boton solo

        /*! en un booleano, lo que hace es cambiar el signo de dicha variable, es decir si esta en true lo pone a false
         * y viceversa false a true
         * activeInHierarchy me devuelve un true si el gameobject esta activo en la jerarquia y un false si esta desactivado
         */

        if (Input.GetKeyDown(KeyCode.P))
        {
            lightTank.SetActive(!lightTank.activeInHierarchy);

        }

    //Manera 2 botones y no limpia
     /*   if(Input.GetKeyDown(KeyCode.P))
        {
            lightTank.SetActive(false);
        }
        else if(Input.GetKeyDown(KeyCode.O))
        {
            lightTank.SetActive(true);
        }
     */
    }
}
