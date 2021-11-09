using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    private void Update()
    {
        UpdateHUD();
    }


    // Text fields
    public Text heartText;
    public Text pencilText;
    public Text staplerText;
    public Text scissorText;

    // Logic

    //Update the HUD information
    public void UpdateHUD()
    {
        //heartText.text = GameManager.instance.player.hitpoint.ToString();
        heartText.text = "0";
        pencilText.text = GameManager.instance.pencilAmount.ToString();
        staplerText.text = GameManager.instance.staplerAmount.ToString();
        scissorText.text = GameManager.instance.scissorAmount.ToString();
    }
}
