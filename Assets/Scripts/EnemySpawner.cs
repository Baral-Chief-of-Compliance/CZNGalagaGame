using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject smallEnemyPrefab;
    public Transform SpawnPoint;
    public float speed = 1.0f;
    public Transform target;
    private GameObject enemy;

    List<GameObject> enemiesList = new List<GameObject>(0);


    void Start()
    {
        enemy = Instantiate(smallEnemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
        //InvokeRepeating("spawnNewEnimes", 0.1f, 2f);
    }

    void Update()
    {
        enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, target.position, speed);
    }

    void spawnNewEnimes()
    {
        GameObject enemy = Instantiate(smallEnemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
        enemiesList.Add(enemy);

        foreach (var enem in enemiesList)
        {
            Debug.Log(enem.transform.position);
            enem.transform.position = Vector2.MoveTowards(enem.transform.position, target.position, speed);
        }
    }
}
