using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

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
    
    public  List<GameObject> pDeck = new List<GameObject>();

    public void OnClick(){
        for(int i = 0; i < 10; i ++){
            GameObject card = Instantiate(pDeck[Random.Range(0, pDeck.Count)], new Vector2(0,0), Quaternion.identity);
            card.transform.SetParent(PlayerHand.transform, false);
            pDeck.RemoveAt(0);
        }
    }
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

        Shuffle(pDeck);
    }
    
    public static List <GameObject> Shuffle(List<GameObject> deck)
    {
        List<GameObject> pDeck = new List<GameObject>();

        foreach(GameObject card in deck)
        {
            int position = Random.Range(0, deck.Count);
            pDeck.Add((position == pDeck.Count) ? card : deck[position]);
        }
        return pDeck;
    }  
    void Update()
    {
        
    }
}
