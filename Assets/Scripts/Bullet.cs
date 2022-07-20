using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bullet : MonoBehaviour
{
    private float speed = 4f;
    private float rightBound = 10;



    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BiggerEnemy"))
        {
            MainManager.playerScore = MainManager.playerScore + 2;
        }
        else
        {
            MainManager.playerScore++;
        }
        Destroy(gameObject);
        Destroy(other.gameObject);
       
    }
}

