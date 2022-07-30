using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public Behaviour[] disableOnDeath;
    public float health = 100f;
    public float damage;
    public string enemyTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }
    void Die()
    {
        //Disable all the components inside the disableOnDeath array that you will assign from the inspector
        foreach (Behaviour behaviour in disableOnDeath)
        {
            behaviour.enabled = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == enemyTag)
        {
            TakeDamage(damage);
        }
    }

}
