using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private bool reloaded;
    // Start is called before the first frame update
    void Start()
    {
        reloaded = true; 
    }

    // Update is called once per frame
    public float bulletForce = 5f;
    
    public GameObject bulletPrefab;
    public Transform firePoint;
    void Update()
    {
        if (Input.GetMouseButton(0) && reloaded)
        {
            Shoot();
            reloaded = false;
        }

        if(Input.GetKeyDown(KeyCode.R))
            reloaded=true;
            
    }
    void Shoot()
    {

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.Euler(0f, 0f, firePoint.rotation.z + 90f));

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 5f);
    }

}
