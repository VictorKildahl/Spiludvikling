using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("changeTextToSomething", 4);
    }

    public void changeTextToSomething(){

        text.color = Color.white;
    }

}
