using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Poner siempre que vallamos a trabajar con elementos de la interfaz
using TMPro;// Poner para texto

public class UIExample : MonoBehaviour
{
    public GameObject imageUI;
    public Image newImageUI;
    public Sprite newImage;


    public TextMeshProUGUI textUI;
    public string textToShow;
    // Start is called before the first frame update
    void Start()
    {
        /*imageUI.GetComponent<Image>().sprite = newImage;
        imageUI.GetComponent<Image>().preserveAspect = true;*/


        // Cambiar una imagen y se vea otra en el panel
       /* newImageUI.sprite = newImage;
        newImageUI.preserveAspect = true;
        newImageUI.fillAmount = 0.5f;*/

        //textUI.text = "Hola soy un Padawan";
        textUI.text = textToShow;
    }

    // Este metodo va asociado al onclick del boton y tiene que ser publico siempre

    //Dende el onclick de boton le damos al + y hay que meter
    // El Gameobject que lleva el script lleva la funcion y queremos que ejecute el boton
    public void ChangeImage()
    {
        newImageUI.sprite = newImage;
        newImageUI.preserveAspect = true;
        newImageUI.fillAmount = 0.5f;
    }
}
