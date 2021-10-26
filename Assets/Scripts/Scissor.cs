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
            GameManager.instance.ShowText("Scissor!", 20, Color.yellow, transform.position, Vector3.up * 25, 1.5f);
            GameManager.instance.scissorAmount += scissorAmount;

            GameManager.instance.SaveState();
        }
    }
}
