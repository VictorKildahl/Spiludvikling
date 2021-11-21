using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        //if (GameManager.instance != null) {
        //    Destroy(gameObject);
        //    return;
        //}

        //Uncomment this line of code if you wanna restart state.
        //PlayerPrefs.DeleteAll();

        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    //Ressources
    public List<Sprite> playerSprite;
    public List<Sprite> weaponSprite;
    public List<int> weaponAmount;

    //References
    public Player player;
    public FloatingTextManager floatingTextManager;

    //Logic
    public int pencilAmount;
    public int staplerAmount;
    public int scissorAmount;

    //Floating Text
    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }

    //Save state
    public void SaveState()
    {
        string s = "";

        s += pencilAmount.ToString() + "|";
        s += staplerAmount.ToString() + "|";
        s += scissorAmount.ToString();

        PlayerPrefs.SetString("SaveState", s);
        Debug.Log("Save state");
    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {
        if (!PlayerPrefs.HasKey("SaveState")) {
            return;
        }

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        pencilAmount = int.Parse(data[0]);
        staplerAmount = int.Parse(data[1]);
        scissorAmount = int.Parse(data[2]);

        Debug.Log("Load state");
    }
}
