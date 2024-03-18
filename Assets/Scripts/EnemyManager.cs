using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Crear enemigos en posisiones alatorias prefinidas
    public GameObject tankEnemyPrefab; // Hace referencia al prefab del enemigo, el original
    public Transform[] positionsEnemy; // Creamos una array de transforms
    //vamos a GameManager y metemos el scrip enemymanager, vamos al prefab y cogemos al enemigo a tank enemy
    //bloqueamos el inspector, seleccionamos los enemigos primer elenemento + shith y ultimo y arrastramos y quitamos candado
    public Transform parentEnemies;
    public float time; // para que aparezcan los enemigos en un determinado tiempo
    void Start()
    {
        // invocamos al metodo crear y pulsamos play invocara a uno y luego al tiempo otro en game manager
        InvokeRepeating("CreateEnemies", time, time);
    }

    // Creamos una funcion 
    void CreateEnemies()
    {
        int n = Random.Range(0, positionsEnemy.Length); // le decimos que nos devuelva un numero randon desde 0 a la longitud del array y que el ultimo numero nunca devolvera
        GameObject cloneTankEnemy = Instantiate(tankEnemyPrefab, positionsEnemy[n].position, positionsEnemy[n].rotation);
        cloneTankEnemy.transform.SetParent(parentEnemies); // que los clones de los  ponga como hijos de ParentEnemies
    }

    //Creamos una funcion publica para que cancele la invocacion de enemigos al morir y esta sea llamada desde el gameManager
    public void StopCreatingEnemies()
    {
        CancelInvoke();
    }
}
