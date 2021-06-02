using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    Rigidbody2D rb2d;

    [SerializeField] public Vector2 _initialForce;
        
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
        AddInitialForce();
    }

    private void AddInitialForce()
    {
        rb2d.AddForce(_initialForce, ForceMode2D.Impulse);
    }

}
