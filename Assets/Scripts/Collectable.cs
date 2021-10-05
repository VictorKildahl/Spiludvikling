using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable_tilemap
{
    // Logic
    protected bool opened;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            OpenElevator();
        }
    }

    protected virtual void OpenElevator()
    {
        opened = true;
    }
}
