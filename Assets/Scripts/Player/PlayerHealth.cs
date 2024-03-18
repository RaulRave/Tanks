using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameManager gameManager;// variable para comunicar a la clase gamemanager y invocar a la funcion gameover
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BallEnemy"))
        {
            Destroy(other.gameObject); // Destruyo la bala
            DeathPlayer();
        }
    }

    void DeathPlayer()
    {
        gameManager.GameOver();
        Destroy(gameObject); // Destruyo al player
    }
}
