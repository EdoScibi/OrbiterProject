using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] public float BossMaxHealth = 30f;
    [SerializeField] public float BossCurrentHealth;
    [SerializeField] private float _damageTaken = 1f;

    public BossHealthBarScript healthBar;

    private void Start()
    {
        BossCurrentHealth = BossMaxHealth;
        healthBar.SetMaxHealth(BossMaxHealth);

    }

    private void Update()
    {
        healthBar.SetHealth(BossCurrentHealth);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Projectile")
        {
            Debug.Log("I took damage");
            BossCurrentHealth -= _damageTaken;
        }
    }

   
}
