using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DrawCards : MonoBehaviour
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

    public GameObject[] cards; // Array to hold references to card GameObjects
    public Text winnerText; // Reference to the UI Text component for displaying winner information

    private List<GameObject> pDeck = new List<GameObject>(); // List to hold references to all card GameObjects in the deck
    private bool[] Dealt; // Array to track whether each card has been dealt
    private int round = 1; // Variable to track the current round

    void Start()
    {
        Dealt = new bool[cards.Length]; // Initialize the dealt array

        // Fill the deck with references to all card GameObjects
        foreach (GameObject card in cards)
        {
           pDeck.Add(Card1);
           pDeck.Add(Card2);
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

        // Shuffle the deck
        ShuffleDeck();
    }

    void ShuffleDeck()
    {
        // Fisher-Yates shuffle algorithm to shuffle the deck
        for (int i = pDeck.Count - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            GameObject temp = pDeck[i];
            pDeck[i] = pDeck[j];
            pDeck[j] = temp;
        }
    }

    public void DealCards( int NumOfCards = 10)
    {
        // Deal the specified number of cards to the player's hand
        for (int i = 0; i < NumOfCards; i++)
        {
            // Find the first undealt card in the deck
            int index = FindUndealtCard();

            if (index != -1)
            {
                // Instantiate the card and add it to the player's hand
                GameObject card = Instantiate(pDeck[index], new UnityEngine.Vector2(0,0), UnityEngine.Quaternion.identity);
                card.transform.SetParent(PlayerHand.transform, false);

                // Mark the card as dealt
                Dealt[index] = true;
            }
            else
            {
                break;
            }
        }
    }

    int FindUndealtCard()
    {
        // Find the index of the first undealt card in the deck
        for (int i = 0; i < pDeck.Count; i++)
        {
            if (!Dealt[i])
            {
                return i;
            }
        }
        return -1; // Return -1 if all cards have been dealt
    }

    public void OnClick()
    {
        // Deal cards based on the current round
        switch (round)
        {
            case 1:
                DealCards(10);
                break;
            case 2:
                DealCards(3);
                break;
            case 3:
                if (winnerText.text == "")
                {
                    DealCards(4);
                }
                break;
            default:
                break;
        }
    }

    void Update()
    {
        // Update the current round from the GameManager or any other source
        // For demonstration purposes, let's assume it's updated externally
        // For example:
        // round = GameManager.Instance.GetCurrentRound();
    }
}
    
   /* public  List<GameObject> pDeck = new List<GameObject>();

    void Start()
    {
       pDeck.Add(Card1);
       pDeck.Add(Card2);
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
        
    }*/
