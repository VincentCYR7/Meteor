using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject EnemyPrefab;

    public float fireRate = 4000000f;
    private float nextFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            var enemy = Instantiate(EnemyPrefab, new Vector3(14f, -3f, 0f), Quaternion.identity);
        }

    }
}
