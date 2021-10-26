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
            GameManager.instance.ShowText("Stapler!", 20, Color.yellow, transform.position, Vector3.up * 25, 1.5f);
            GameManager.instance.staplerAmount += staplerAmount;

            GameManager.instance.SaveState();
        }
    }
}
