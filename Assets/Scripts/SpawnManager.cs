using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public float spawnRate = 2f;
    public float spawnTimer = 2f;
    public GameObject enemyPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer <= 0)
        {
            Vector2 enemyPos = new Vector2(Random.Range(-28f, 8f),  Random.Range(8f, 20f));
            float distanceToPlayer = Vector2.Distance(enemyPos, PlayerController.instance.transform.position);
            while (Mathf.Abs(distanceToPlayer) <= 2)
            {
                enemyPos = new Vector2(Random.Range(-28f, 8f),  Random.Range(8f, 20f));
                distanceToPlayer = Vector2.Distance(enemyPos, PlayerController.instance.transform.position);
            }
            Instantiate(enemyPrefab, enemyPos, Quaternion.identity);
            spawnTimer = spawnRate;
        }
        else
        {
            spawnTimer -= Time.deltaTime;
        }
    }
}
