using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
    //INHERITANCE
    private float secondSpeed = 3f;
    private float verticalSpeed = 5f;
    private int counter = 0;

    
    //POLYMORPHISM
    public override void MoveLeft()
    {
        Debug.Log("Hey it's different.");
        transform.Translate(Vector3.left* Time.deltaTime * secondSpeed);
    }


}
