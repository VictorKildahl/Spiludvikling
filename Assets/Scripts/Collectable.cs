using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable_tilemap
{
    // Logic
    protected bool opened;

    protected bool collected;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player" || coll.name == "Weapon")
        {
            OpenElevator();
            OnCollect();
        }
    }

    protected virtual void OpenElevator()
    {
        opened = true;
    }

    protected virtual void OnCollect()
    {
        collected = true;
    }
}
