using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// Para gestionar la carga de escenas entre niveles panel
using TMPro; //Para mostrar por pantalla el numero de enemigos eliminados

public class GameManager : MonoBehaviour
{
    // Panel Game Over
    public GameObject panelGameOver;
    public TextMeshProUGUI textNumEnemies;

    int numEnemies;// Me almacena el numero de enemigos que he eliminado
 
    //Funcion publica que se encarga del game over para que lo active cuando mueras
    public void GameOver()
    {
        // desahilito el script para que no salgan mas enemigos
        /*  panelGameOver.SetActive(true);
          GetComponent<EnemyManager>().enabled = false;*/

        // para cancelar los enemigos llamando a la funcion
        panelGameOver.SetActive(true);
        GetComponent<EnemyManager>().StopCreatingEnemies();
    }

    //Para cargar una escena con el boton
    public void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");

        //Vamos a Button, onclick en object metemos Gamemanager por que tiene el Scrip y la funcion LoadScene
    }

    public void AddEnemy()

    {
        numEnemies++; // se encarga de sumar +1 al numero de enemigos que matemos y lo muestre en el interfaz
        textNumEnemies.text = numEnemies.ToString();// cambiar  es una variable int se convierte en String
    }
}
// a player heal le pnemos el game object de gamemanager en game manager