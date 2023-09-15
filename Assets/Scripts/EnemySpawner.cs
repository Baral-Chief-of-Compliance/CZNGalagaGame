using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject bigEnemy;
    public GameObject middleEnemy;
    public GameObject smallEnemy;
    public int EnemyCount = 10;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < EnemyCount; i++)
        {
            GameObject enemy = Instantiate(smallEnemy, spawnPoint.position, spawnPoint.rotation);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
