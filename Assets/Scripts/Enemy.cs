using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 5f;
    private float leftBound = -10;

    // Update is called once per frame
    void Update()
    {
        MoveLeft();
        //Destroy the object once it leaves the screen
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

    }

    public virtual void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
