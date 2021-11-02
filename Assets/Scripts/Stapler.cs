using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stapler : Collectable
{
    public Sprite staplerPickedUp;
    public int staplerAmount = 1;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = staplerPickedUp;
            GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("Amount of staplers: " + staplerAmount);

            GameManager.instance.SaveState();
        }
    }
}
