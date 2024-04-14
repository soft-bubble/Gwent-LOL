using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eDrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;
    public GameObject Card5;
    public GameObject Card6;
    public GameObject Card7;
    public GameObject Card8;
    public GameObject Card9;
    public GameObject Card10;
    public GameObject Card11;
    public GameObject Card12;
    public GameObject Card13;
    public GameObject Card14;
    public GameObject Card15;
    public GameObject Card16;
    public GameObject Card17;
    public GameObject Card18;
    public GameObject Card19;
    public GameObject Card20;
    public GameObject Card21;
    public GameObject Card22;
    public GameObject Card23;
    public GameObject Card24;
    public GameObject Card25;
    public GameObject Card26;   
    public GameObject Card27;

    public GameObject EnemyHand;
    
    public bool firstdraw = false;
    public bool seconddraw = false;
    public bool thirddraw = false; 
    public int Round = 1; 
    private int position = 0;
    public  List<GameObject> eDeck = new List<GameObject>();

    public void CheckCards() 
    {
        bool cardDealt = false;

        do
        {
            if (eDeck.Count > 0)
            {
                position = Random.Range(0, eDeck.Count);
                if (position >= 0 && position < eDeck.Count)
                {
                    if (eDeck[position].GetComponent<CardClass>().AlreadyDrewIt == false)
                    {
                        GameObject card = Instantiate(eDeck[position], new UnityEngine.Vector2(0,0), UnityEngine.Quaternion.identity);
                        card.transform.SetParent(EnemyHand.transform, false);
                        eDeck[position].GetComponent<CardClass>().AlreadyDrewIt = true;
                        cardDealt = true;
                    }
                }
            }
        } while (!cardDealt);
    }

    public void OnClick()
    {
        if (firstdraw == false)
        {
            DrawCards(10);
            firstdraw = true;
        }

        if (seconddraw == false && Round == 2)
        {
            DrawCards(2);
            seconddraw = true;
        }

        if (thirddraw == false && Round == 3)
        {
            DrawCards(2);
            thirddraw = true;
        }
    }

    public void DrawCards(int numberOfDraws)
    {
        for (int i = 0; i < numberOfDraws; i++)
        {
            CheckCards();
        }
    }

    void Update()
    {
        //Round = GameObject.Find("GameManager").GetComponent<GameManager>().Round;
        //Turn = GameObject.Find("TurnCounter").GetComponent<SetTurn>().Shift;
    }
}
