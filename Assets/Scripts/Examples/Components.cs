using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{
    Light ligthTank;
         
    // Start is called before the first frame update
    void Start()
    {
        ligthTank = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        /* Manera limpia de eliminar el componente y menos recursos 
         * el estado del componente va ser igual al estado que esta igual
         */
        if (Input.GetKeyDown(KeyCode.P))
        {
            //ligthTank.enabled = !ligthTank.enabled;


            bool stateLight = ligthTank.enabled;
            ligthTank.enabled = !stateLight;

        }


        //Manera 2 botones y no limpia
        /*  if (Input.GetKeyDown(KeyCode.P))
          {
              ligthTank.enabled = false;
          }
          else if (Input.GetKeyDown(KeyCode.O))
          {
              ligthTank.enabled = true;
          }
        */
    }
}
