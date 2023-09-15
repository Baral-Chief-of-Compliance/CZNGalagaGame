using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;


    public float bulletForce = 20f;


    void Start()
    {
        InvokeRepeating("Shoot", 0.1f, 0.5f);
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
