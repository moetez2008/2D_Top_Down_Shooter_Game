using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombi : MonoBehaviour
{
    Transform player;
    Vector2 dir;
    Rigidbody2D rb;
    public float speed = 2f;
    public GameObject zombiePrefab;
    int i = 0;




    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").transform;
        InvokeRepeating("Spawn", .5f, 2);
        InvokeRepeating("repeat", .5f, 1);
        
    }

    // Update is called once per frame
  private void Update()
    {
        if (player)
            dir = (player.position - transform.position).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity = dir * speed;

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }

    void Spawn()
    {
        Vector2 position = RandomCircle(Vector3.zero, 20);
        Instantiate(zombiePrefab, position, Quaternion.identity);
    }

    void repeat()
    {
        Debug.Log("Call " + i);
        i++;
    }

}
