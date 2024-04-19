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
    private int cardsDealt = 0;
    public  List<GameObject> eDeck = new List<GameObject>();

    public bool IsCardReturned(GameObject card)
    {
        if (card!= null && card.GetComponent<CardClass>()!= null)
        {
            return card.GetComponent<CardClass>().AlreadyDrewIt;
        }
        else
        {
            return false;
        }
    }

public bool CheckCards() /*Method to shuffle the cards, it checks if it was already dealt and excludes them*/
{
    bool cardDealt = false;
    position = 0;

    if (eDeck!= null && eDeck.Count > 0)
    {
        if (eDeck.Exists(card =>!card.GetComponent<CardClass>().AlreadyDrewIt))
        {
            do
            {
                cardDealt = false;
                position = Random.Range(0, eDeck.Count);
                if (position >= 0 && position < eDeck.Count)
                {
                    if (eDeck[position]!= null && !IsCardReturned(eDeck[position])) /* eDeck[position].GetComponent<CardClass>().AlreadyDrewIt == false*/
                    {
                        GameObject card = Instantiate(eDeck[position], new Vector2(0, 0), Quaternion.identity);
                        card.transform.SetParent(EnemyHand.transform, false);
                        eDeck[position].GetComponent<CardClass>().AlreadyDrewIt = true;
                        eDeck.RemoveAt(position);
                        cardDealt = true;
                        cardsDealt++;
                    }
                }
                position++;
            } while (!cardDealt && eDeck.Exists(card =>!card.GetComponent<CardClass>().AlreadyDrewIt)  && eDeck.Count > 0);
        }
    }
    return cardDealt;
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

    public void DrawCards(int numberOfDraws) /*Method to call the CheckCards method*/
    {
        if (numberOfDraws <= 0)
        {
        return;
        }
        for (int i = 0; i < numberOfDraws; i++)
        {
            if (eDeck.Count > 0)
            {
                if (CheckCards())
                {
                }
            }
            else
            {
            break;
            }
        }     
    }

    public void ResetCards()
{
    foreach (GameObject card in eDeck)
    {
        if (card!= null && card.GetComponent<CardClass>()!= null)
        {
            card.GetComponent<CardClass>().AlreadyDrewIt = false;
        }
    }
}
    void Start() /*Makes sure the cards are into the list when the game starts*/
    {
        ResetCards();
        eDeck.Add(Card1);
        eDeck.Add(Card2);
        eDeck.Add(Card3);
        eDeck.Add(Card4);
        eDeck.Add(Card5);
        eDeck.Add(Card6);
        eDeck.Add(Card7);
        eDeck.Add(Card8);
        eDeck.Add(Card9);
        eDeck.Add(Card10);
        eDeck.Add(Card11);
        eDeck.Add(Card12);
        eDeck.Add(Card13);
        eDeck.Add(Card14);
        eDeck.Add(Card15);
        eDeck.Add(Card16);
        eDeck.Add(Card17);
        eDeck.Add(Card18);
        eDeck.Add(Card19);
        eDeck.Add(Card20);
        eDeck.Add(Card21);
        eDeck.Add(Card22);
        eDeck.Add(Card23);
        eDeck.Add(Card24);
        eDeck.Add(Card25);
        eDeck.Add(Card26);
        eDeck.Add(Card27);
    }

    public void ResetDrawVariables()
    {
    firstdraw = false;
    seconddraw = false;
    thirddraw = false;
    }

    void Update()
    {
        GameObject gameManager = GameObject.Find("GameManager");
    if (gameManager!= null)
    {
        Round = gameManager.GetComponent<GameManager>().Round;
        if (Round > 1)
        {
            ResetDrawVariables();
        }
    }
        //Turn = GameObject.Find("TurnCounter").GetComponent<SetTurn>().Shift;
    }
}



/*bool cardDealt = false;

        do
        {
            cardDealt = false;
            if ( eDeck != null && eDeck.Count > 0)
            {
                position = Random.Range(0, eDeck.Count);
                if (position >= 0 && position < eDeck.Count)
                {
                    if (    eDeck[position]!= null && !IsCardReturned( eDeck[position]))
                    {
                        GameObject card = Instantiate(eDeck[position], new Vector2(0,0), Quaternion.identity);
                        card.transform.SetParent(EnemyHand.transform, false);
                        eDeck[position].GetComponent<CardClass>().AlreadyDrewIt = true;
                        eDeck.RemoveAt(position);
                        cardDealt = true;
                        cardsDealt++;
                    }
                }
            }
            else
            {
                break;
            }
        } while (!cardDealt && eDeck.Exists(card =>!card.GetComponent<CardClass>().AlreadyDrewIt));
     return cardDealt;*/