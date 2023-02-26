using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points = 0;
    public Projectile laserPrefab;
    public float shootInterval = 0.5f;
    public float shootTimer = 0;
    public Transform posShoot;

    void Update()
    {
        Move();
        
        shootTimer += Time.deltaTime;
        if (shootTimer >= shootInterval)
        {
            Shoot();
            shootTimer = 0;
        }
    }


    void Shoot()
    {
        Instantiate(laserPrefab, posShoot.position, transform.rotation);
    }

    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
    }
}
