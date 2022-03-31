using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishedGame : MonoBehaviour
{
    public GameObject reloj;
    public GameObject tiempo;
    public GameObject quests;
    public GameObject player;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject bg;
    public GameObject grid;
    public GameObject ind;
    public GameObject txtgo;
    public GameObject txtwg;

    public GameObject back;
    public GameObject reset;

    public Text points;

    private float pts = 0;

    void Start()
    {
        //gameObject.SetActive(false);
        GamePoints();
    }

    void GamePoints()
    {
        enemy1.SetActive(false);
        enemy2.SetActive(false);
        player.SetActive(false);
        bg.SetActive(false);
        grid.SetActive(false);
        ind.SetActive(false);
        back.SetActive(true);
        reset.SetActive(true);
     
        int tmp = (int) tiempo.GetComponent<Timer>().timeValue;
        int pos = count(quests.GetComponent<QuestManager>().questCompleted, true);

        if (pos == 8)
        {
            SoundManager.PlaySound("WinSound");
            txtwg.SetActive(true);
        }
        else
        {
            txtgo.SetActive(true);
            SoundManager.PlaySound("gameOverSound");
        }

        pts = tmp* (pos*50) * 0.5f;
        points.text = "Points:  "+pts;

        reloj.SetActive(false);
    }

    private int count(bool[] array, bool flag)
    {
        int value = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == flag) value++;
        }

        return value;
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Back()
    {
        SceneManager.LoadScene("mainMenu");
    }


}