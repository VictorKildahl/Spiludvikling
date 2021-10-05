using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator : Collectable
{
    public Sprite openedElevator;

    protected override void OpenElevator()
    {
        if (!opened)
        {
            opened = true;
            GetComponent<SpriteRenderer>().sprite = openedElevator;
            Debug.Log("Elevator Opened");

            StartCoroutine(Wait(2.5f));
        }
    }

    IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
