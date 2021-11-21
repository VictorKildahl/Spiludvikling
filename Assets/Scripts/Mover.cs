using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mover : Fighter
{
    protected Vector3 moveDelta;

    protected virtual void UpdateMotor(float moveSpeed, Vector3 movement)
    {
        moveDelta = new Vector3(movement.x * moveSpeed, movement.y * moveSpeed, 0);

        //    //Flipes sprite
        if (moveDelta.x > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        //    //Moves player
        transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
    }
}
