using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShoot : MonoBehaviour
{
    [SerializeField] private GameObject prefabs;
    [SerializeField] private Transform pointBulletShoot;
    [SerializeField] private float bulletSpeed;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(prefabs, pointBulletShoot.position, pointBulletShoot.rotation);
        
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.velocity = pointBulletShoot.up * bulletSpeed;
    }
}
