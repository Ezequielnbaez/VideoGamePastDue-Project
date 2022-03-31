using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void PlayGame()
    {
        SoundManager.PlaySound("SelectingSound");
        SceneManager.LoadScene("juego");
    }
    public void Quit()
    {
        SoundManager.PlaySound("SelectingSound");
        Application.Quit();
    }
    public void Credit()
    {
        SoundManager.PlaySound("SelectingSound");
        SceneManager.LoadScene("credits");
    }
    public void Back()
    {
        SoundManager.PlaySound("SelectingSound");
        SceneManager.LoadScene("mainMenu");
    }

}
