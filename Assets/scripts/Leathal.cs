using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leathal : MonoBehaviour
{
    public float damage;
    public string zombie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zombie")
        {
            collision.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
        }
    }
}
