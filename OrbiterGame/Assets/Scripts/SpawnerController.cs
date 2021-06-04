using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] public GameObject asteroidPrefab = null;

    [SerializeField] private float _timeToSpawn = 0f;
    [SerializeField] private float _timeToNextSpawn = 0f;
    [SerializeField] private bool _doNotSpawn = false;

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
        if (Time.time >= _timeToSpawn)
        {
            if (_doNotSpawn == false)
            {
                SpawnAsteroid();
                _timeToSpawn += _timeToNextSpawn;
            }

            else
            {
                Debug.Log("SPAWN DISABLED");
                _timeToSpawn += _timeToNextSpawn;
            }

        }
               
    }

    private void SpawnAsteroid()
    {
        Instantiate(asteroidPrefab,
                    transform.position,
                    transform.rotation);
    }

}