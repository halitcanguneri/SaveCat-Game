using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pakize : MonoBehaviour
{

    public int score = 0;
    public GameManager managerGame;
    public AudioSource AudioSourcebg;
    public AudioSource AudioSourcemama;
    
    public AudioSource AudioSourcekaka;


    private void Start()
    {
        Time.timeScale = 1;

    }






    //etkile�imler alan�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "mama(Clone)")//zarars�z
        {
            managerGame.ScoreArtt�r();
            AudioSourcemama.Play();



        }
        if (collision.gameObject.name == "kemik(Clone)")//zarars�z
        {
            managerGame.ScoreArtt�r();
            AudioSourcemama.Play();


        }
        if (collision.gameObject.name == "kaka(Clone)")//zararl�
        {
            managerGame.ScoreAzalt();
            AudioSourcebg.Stop();
            AudioSourcekaka.Play();

        }
        


    }
}

