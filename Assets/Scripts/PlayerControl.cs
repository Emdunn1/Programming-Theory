using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 5f;
    public Bullet bulletPrefab;
    public Transform SpawnPoint;

  
    void Update()
    {
        //ABSTRACTION
        Move();
        Shoot();
    }


    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, SpawnPoint.position, SpawnPoint.rotation);
        }

    }

    private void Move()
    {
        var movement = Input.GetAxis("Vertical"); 
        transform.position += new Vector3(0, movement, 0) * Time.deltaTime * speed;
        
    }
}
