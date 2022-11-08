using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public List<Transform> spawnpoints;
    public GameObject EnemyPrefab, Enemies;
    Transform location;
    public float enemyburstcount = 3, spawnTime = 1;
    float updateTime;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        spawnpoints.Add(child);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > updateTime)
        {
            updateTime = Time.time + spawnTime;
            Enemyspawn();
        }
        
    }
    public void Enemyspawn()
    {
        if (Enemies.transform.childCount < 3)
        {
            location = spawnpoints[Random.Range(0, transform.childCount)];
            var enemyInstance = Instantiate(EnemyPrefab, location);
            enemyInstance.transform.SetParent(Enemies.transform);
            enemyInstance.transform.LookAt(Vector3.zero);
        }
    }
}
