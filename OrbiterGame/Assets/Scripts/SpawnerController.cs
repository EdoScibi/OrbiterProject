using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] public GameObject asteroidPrefab = null;

    private void Start()
    {
        Instantiate(
            asteroidPrefab,
            transform.position,
            transform.rotation);
    }
}
