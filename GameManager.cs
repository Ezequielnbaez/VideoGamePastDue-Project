using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerMovement player;
    public Timer timer;
    public GameObject QM;
    public GameObject gameOver;


    public int score { get; private set; }

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        CountDown();
        QuestsCount();
    }

    private void NewGame()
    {
        NewRound();
    }

    private void CountDown()
    {
        if (this.timer.timeValue == 0)
        {
            this.player.DeathSequence();
            GameOver();
        }
    }

    private void NewRound()
    {
        this.gameOver.SetActive(false);
    }


    private void GameOver()
    {
        this.gameOver.SetActive(true);

    }


    public void PlayerCaught()
    {
        this.player.DeathSequence();

        GameOver();

    }

    public void QuestsCount()
    {
        int pos = count(QM.GetComponent<QuestManager>().questCompleted, true);
        if(pos == 8)
        {
            GameOver();
        }
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


}
