using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Round = 1;
    public Text ShurimaWinsText;
    public string ShurimaPoints;
    public Text ShadowIslesWinsText;
    public string ShadowIslesPoints;
    public Text WinnerText;


    public bool playerSurrender;
    public bool enemySurrender;
    public bool GameOver = false;
    private int ShurimaVictories = 0;
    private int ShadowIslesVictories = 0;
    private int Hand1;
    private int Hand2;
    private bool Edraws1;
    private bool Edraws2;
    private bool Edraws3;
    private bool Pdraws1;
    private bool Pdraws2;
    private bool Pdraws3;
    public bool Winner2nd;
    public bool Winner1st;
    public Text nextround;
    //private Animator animnext;

    public void DecideWinner(){
        /*First round*/
        if(Round == 1 && Hand1 == 0 && Hand2 == 0 && Pdraws1 && Edraws1) 
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);

            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
                Winner1st = true;
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
                Winner1st = false;
            }
            Round += 1;
            // animnext.SetTrigger("shownext");
        }
        if(Round == 1 && playerSurrender && enemySurrender && Pdraws1 && Edraws1)
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);

            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
                Winner1st = true;
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
                Winner1st = false;
            }
            Round += 1;
            // animnext.SetTrigger("shownext");
        }
        if(Round == 1 && playerSurrender && Hand2 == 0 && Pdraws1 && Edraws1)  
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);
            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
                Winner1st = true;
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
                Winner1st = false;
            }
            Round += 1;
            //animnext.SetTrigger("shownext");
        }
            if(Round == 1 && Hand1 == 0 && enemySurrender && Pdraws1 && Edraws1)  //gutts no tiene cartas y griffith se rindio
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);
            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
                Winner1st = true;
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
                Winner1st = false;
            }
            Round += 1;
            //animnext.SetTrigger("shownext");
        }
        //segunda round
        if(Round == 2 && Hand1 == 0 && Hand2 == 0 && Pdraws2 && Edraws2) //lo mismo
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);
            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
                Winner2nd = true;
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
                Winner2nd = false;
            }
            Round += 1;
            //animnext.SetTrigger("shownext");
        }
        if(Round == 2 && playerSurrender && enemySurrender && Pdraws2 && Edraws2)
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);
            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
                Winner2nd = true;
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
                Winner2nd = false;
            }
            Round += 1;
            // animnext.SetTrigger("shownext");
        }
        if(Round == 2 && playerSurrender && Hand2 == 0 && Pdraws2 && Edraws2)
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);
            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
                Winner2nd = true;
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
                Winner2nd = false;
            }
            Round += 1;
            //animnext.SetTrigger("shownext");
        }
        if(Round == 2 && Hand1 == 0 && enemySurrender && Pdraws2 && Edraws2)
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);
            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
                Winner2nd = true;
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
                Winner2nd = false;
            }
            Round += 1;
            //animnext.SetTrigger("shownext");
        }

                    //tercer round
        if(Round == 3 && Hand1 == 0 && Hand2 == 0 && Pdraws3 && Edraws3) // again
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);
            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
            }
            Round = 0;
        }
         if(Round == 3 && playerSurrender && enemySurrender && Pdraws3 && Edraws3)
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);
            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
            }
            Round = 0;
        }
         if(Round == 3 && playerSurrender && Hand2 == 0 && Pdraws3 && Edraws3)
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);
            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
            }
            Round = 0;
        }
         if(Round == 3 && Hand1 == 0 && enemySurrender && Pdraws3 && Edraws3)
        {
            int ShurimaPts = int.Parse(ShurimaPoints);
            int ShadowIslesPts = int.Parse(ShadowIslesPoints);
            if(ShurimaPts >= ShadowIslesPts)
            {
                ShurimaVictories += 1;
                ShurimaWinsText.text = ShurimaVictories.ToString();
            }

            if(ShadowIslesPts >= ShurimaPts)
            {
                ShadowIslesVictories += 1;
                ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
            }
            Round = 0;
        }
    }
  
    void Update() 
    {
        Hand1 = GameObject.Find("PlayerHand").GetComponent<HandClass>().Cards;
        Hand2 = GameObject.Find("EnemyHand").GetComponent<HandClass>().Cards;

        playerSurrender = GameObject.Find("PlayerHand").GetComponent<HandClass>().Surrender;
        enemySurrender = GameObject.Find("EnemyHand").GetComponent<HandClass>().Surrender;


        Edraws1 = GameObject.Find("EnemyDeck").GetComponent<eDrawCards>().firstdraw;
        Pdraws1 = GameObject.Find("PlayerDeck").GetComponent<pDrawCards>().firstdraw;
        Edraws2 = GameObject.Find("EnemyDeck").GetComponent<eDrawCards>().seconddraw;
        Pdraws2 = GameObject.Find("PlayerDeck").GetComponent<pDrawCards>().seconddraw;
        Edraws3 = GameObject.Find("EnemyDeck").GetComponent<eDrawCards>().thirddraw;
        Pdraws3 = GameObject.Find("PlayerDeck").GetComponent<pDrawCards>().thirddraw;



                    //Decidiendo el ganador
        if(GameOver == false && ShurimaVictories == ShadowIslesVictories && ShadowIslesVictories == 2)
        {
            GameOver = true;
            //SceneManager.LoadScene(9);
        }
        else if(GameOver == false && ShurimaVictories == 2)
        {
            GameOver = true;
            //SceneManager.LoadScene(7);
        }
        else if(GameOver == false && ShadowIslesVictories == 2)
        {
            GameOver = true;
            //SceneManager.LoadScene(8);
        }
    }
}
