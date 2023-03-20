using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public Text scoreText;
    public int score;



    public void Menu()
    {
        SceneManager.LoadScene(0);

    }
    public void Play()
    {
        SceneManager.LoadScene(1);

    }

    public void HowToPlay()
    {
        SceneManager.LoadScene(2);

    }

    public void quit()
    {
        Application.Quit();

    }

}

