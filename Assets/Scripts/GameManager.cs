using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
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
{
    int shurimaPoints = int.Parse(ShurimaPoints);
    int shadowIslesPoints = int.Parse(ShadowIslesPoints);

    bool shurimaVictory = false;
    bool shadowIslesVictory = false;

    for (int round = 1; round <= 3; round++)
    {
        bool playerHasNoCards = Hand1 == 0;
        bool enemyHasNoCards = Hand2 == 0;
        bool bothPlayersSurrendered = playerSurrender && enemySurrender;
        bool playerDraws = Pdraws1 && Pdraws2 && Pdraws3;
        bool enemyDraws = Edraws1 && Edraws2 && Edraws3;

        if (playerHasNoCards && enemyHasNoCards && playerDraws && enemyDraws && bothPlayersSurrendered)
        {
            shurimaVictory = shurimaPoints >= shadowIslesPoints;
            shadowIslesVictory = shadowIslesPoints > shurimaPoints;
            break;
        }

        if (playerHasNoCards && enemyHasNoCards && playerDraws && enemyDraws)
        {
            shurimaVictory = shurimaPoints >= shadowIslesPoints;
            shadowIslesVictory = shadowIslesPoints > shurimaPoints;
            Round++;
            // animnext.SetTrigger("shownext");
            break;
        }
    }

    if (shurimaVictory)
    {
        ShurimaVictories++;
        ShurimaWinsText.text = ShurimaVictories.ToString();
    }

    if (shadowIslesVictory)
    {
        ShadowIslesVictories++;
        ShadowIslesWinsText.text = ShadowIslesVictories.ToString();
    }

    if (Round == 4)
    {
        Round = 0;
    }
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
        }
        else if(GameOver == false && ShurimaVictories == 2)
        {
            GameOver = true;
        }
        else if(GameOver == false && ShadowIslesVictories == 2)
        {
            GameOver = true;
        }
    }
}
