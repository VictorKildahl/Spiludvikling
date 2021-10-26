using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pencil : Collectable
{
    public Sprite pencilPickedUp;
    public int pencilAmount = 1;
    //public Text pencilText;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = pencilPickedUp;
            GetComponent<BoxCollider2D>().enabled = false;
            GameManager.instance.ShowText("Pencil!", 20, Color.yellow, transform.position, Vector3.up * 25, 1.5f);
            GameManager.instance.pencilAmount += pencilAmount;
            //pencilText.text = GameManager.instance.pencilAmount.ToString();

            GameManager.instance.SaveState();
            
        }
    }
}
