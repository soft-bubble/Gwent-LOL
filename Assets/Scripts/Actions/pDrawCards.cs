using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pDrawCards : MonoBehaviour
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

    public GameObject PlayerHand;
    public bool firstdraw = false;
    public bool seconddraw = false;
    public bool thirddraw = false; 
    public int Round = 1; 
    private int position = 0;
    // private bool Turn;
    public List <GameObject> pDeck = new List<GameObject>();

    public void CheckCards() 
{
    bool cardDealt = false;

    do
    {
        if (pDeck.Count > 0)
        {
            position = Random.Range(0, pDeck.Count);
            if (position >= 0 && position < pDeck.Count)
            {
                if (pDeck[position]!= null && pDeck[position].GetComponent<CardClass>().AlreadyDrewIt == false)
                {
                    GameObject card = Instantiate(pDeck[position], new UnityEngine.Vector2(0,0), UnityEngine.Quaternion.identity);
                    card.transform.SetParent(PlayerHand.transform, false);
                    pDeck[position].GetComponent<CardClass>().AlreadyDrewIt = true;
                    cardDealt = true;
                }
            }
        }
        else{
            break;
        }
    } while (!cardDealt);
}

   public void OnClick()
{
    //  if (!Turn) return;

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
        if (pDeck.Count > 0)
        CheckCards();
    }
}
  void Start()
{
    pDeck.Add(Card1);
    pDeck.Add(Card3);
    pDeck.Add(Card4);
    pDeck.Add(Card5);
    pDeck.Add(Card6);
    pDeck.Add(Card7);
    pDeck.Add(Card8);
    pDeck.Add(Card9);
    pDeck.Add(Card10);
    pDeck.Add(Card11);
    pDeck.Add(Card12);
    pDeck.Add(Card13);
    pDeck.Add(Card14);
    pDeck.Add(Card15);
    pDeck.Add(Card16);
    pDeck.Add(Card17);
    pDeck.Add(Card18);
    pDeck.Add(Card19);
    pDeck.Add(Card20);
    pDeck.Add(Card21);
    pDeck.Add(Card22);
    pDeck.Add(Card23);
    pDeck.Add(Card24);
    pDeck.Add(Card25);
    pDeck.Add(Card26);
    pDeck.Add(Card27);

}
   void Update()
    {
        Round = GameObject.Find("GameManager").GetComponent<GameManager>().Round;
        //Turn = GameObject.Find("TurnCounter").GetComponent<SetTurn>().Shift;
    }
}
