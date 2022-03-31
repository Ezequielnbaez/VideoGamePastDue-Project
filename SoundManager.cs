using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip gameOverSound, KeyboardSound, SelectingSound, TaskCompletedSound, TelephoneSound, ErrorSound, NoteSound, WinSound;
    static AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        gameOverSound = Resources.Load<AudioClip>("gameOverSound");
        KeyboardSound = Resources.Load<AudioClip>("KeyboardSound");
        SelectingSound = Resources.Load<AudioClip>("SelectingSound");
        TaskCompletedSound = Resources.Load<AudioClip>("TaskCompletedSound");
        NoteSound = Resources.Load<AudioClip>("NoteSound");
        ErrorSound = Resources.Load<AudioClip>("ErrorSound");
        WinSound = Resources.Load<AudioClip>("WinSound");

        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "gameOverSound":
                audiosrc.PlayOneShot(gameOverSound);
                break;
            case "KeyboardSound":
                audiosrc.PlayOneShot(KeyboardSound);
                break;
            case "SelectingSound":
                audiosrc.PlayOneShot(SelectingSound);
                break;
            case "TaskCompletedSound":
                audiosrc.PlayOneShot(TaskCompletedSound);
                break;
            case "NoteSound":
                audiosrc.PlayOneShot(NoteSound);
                break;
            case "ErrorSound":
                audiosrc.PlayOneShot(ErrorSound);
                break;
            case "WinSound":
                audiosrc.PlayOneShot(WinSound);
                break;
        }

    }


}
