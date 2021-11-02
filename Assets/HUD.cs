using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    private float update;

    void Update()
    {
        update += Time.deltaTime;
        if (update > 1.0f)
        {
            update = 0.0f;
            UpdateHUD();
        }
    }


    // Text fields
    public Text pencilText;
    public Text staplerText;
    public Text scissorText;

    // Logic

    //Update the HUD information
    public void UpdateHUD()
    {
        pencilText.text = GameManager.instance.pencilAmount.ToString();
        staplerText.text = GameManager.instance.staplerAmount.ToString();
        scissorText.text = GameManager.instance.scissorAmount.ToString();
    }
}
