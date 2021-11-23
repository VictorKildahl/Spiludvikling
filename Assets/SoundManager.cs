using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip woman_hitSound, man_hitSound, scissor_swingSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        woman_hitSound = Resources.Load<AudioClip>("Woman_hit");
        man_hitSound = Resources.Load<AudioClip>("Man_hit");
        scissor_swingSound = Resources.Load<AudioClip>("Scissor_swing");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip) {
        switch (clip) {
            case "woman_hit":
                audioSrc.PlayOneShot(woman_hitSound);
                break;
            case "man_hit":
                audioSrc.PlayOneShot(man_hitSound);
                break;
            case "scissor_swing":
                audioSrc.PlayOneShot(scissor_swingSound);
                break;
        }
    }
}
