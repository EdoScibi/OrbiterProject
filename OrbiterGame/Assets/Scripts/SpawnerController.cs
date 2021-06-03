using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] public GameObject asteroidPrefab = null;

    [SerializeField] private float _timetoSpawn = 0f;
    [SerializeField] private float _timetoNextSpawn = 0f;

    private void Start()
    {
        SpawnAsteroid();
    }

    private void Update()
    {
        TimedSpawnAsteroid();
    }

    private void TimedSpawnAsteroid()
    {
        if (Time.time >= _timetoSpawn)
        {
            SpawnAsteroid();
            _timetoSpawn += _timetoNextSpawn;
        }
    }

    private void SpawnAsteroid()
    {
        Instantiate(asteroidPrefab,
                    transform.position,
                    transform.rotation);
    }
}
