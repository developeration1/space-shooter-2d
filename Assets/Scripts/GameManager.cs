using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private List<GameObject> enemyPool;

    public GameObject GetEnemy(GameObject prefab)
    {
        foreach (GameObject enemy in enemyPool)
        {
            if (!enemy.activeSelf)
            {
                enemy.SetActive(true);
                return enemy;
            }
        }
        GameObject newEnemy = Instantiate(prefab);
        enemyPool.Add(newEnemy);
        return newEnemy;
    }

    public void RemoveEnemy(GameObject enemyToRemove)
    {
        foreach (GameObject enemy in enemyPool)
        {
            if(enemy == enemyToRemove)
            {
                enemy.SetActive(false);
                return;
            }
        }
        enemyPool.Add(enemyToRemove);
        enemyToRemove.SetActive(false);
    }
}
