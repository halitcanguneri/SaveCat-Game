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






    //etkileþimler alaný
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "mama(Clone)")//zararsýz
        {
            managerGame.ScoreArttýr();
            AudioSourcemama.Play();



        }
        if (collision.gameObject.name == "kemik(Clone)")//zararsýz
        {
            managerGame.ScoreArttýr();
            AudioSourcemama.Play();


        }
        if (collision.gameObject.name == "kaka(Clone)")//zararlý
        {
            managerGame.ScoreAzalt();
            AudioSourcebg.Stop();
            AudioSourcekaka.Play();

        }
        


    }
}

