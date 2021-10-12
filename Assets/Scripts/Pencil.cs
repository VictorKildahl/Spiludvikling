using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pencil : Collectable
{
    public Sprite pencilPickedUp;
    public int pencilAmount = 1;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = pencilPickedUp;
            GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("Amount of pencils: " + pencilAmount);

            GameManager.instance.SaveState();
        }
    }
}
