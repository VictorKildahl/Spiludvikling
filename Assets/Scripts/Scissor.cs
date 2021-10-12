using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissor : Collectable
{
    public Sprite scissorPickedUp;
    public int scissorAmount = 1;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = scissorPickedUp;
            GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("Amount of scissors: " + scissorAmount);

            GameManager.instance.SaveState();
        }
    }
}
