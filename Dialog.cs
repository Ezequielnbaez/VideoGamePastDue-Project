using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public GameObject dialog;
    public GameObject key;
    public GameObject boss;
    public GameObject player;
    public GameObject enemy1;
    public GameObject enemy2;
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            SoundManager.PlaySound("SelectingSound");
            enemy1.SetActive(true);
            enemy2.SetActive(true);
            dialog.SetActive(false);
            key.SetActive(false);
            boss.SetActive(true);
            player.GetComponent<PlayerMovement>().enabled = true;
            gameObject.SetActive(false);
        }
    }
}
