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
    
    public  List<GameObject> eDeck = new List<GameObject>();

    public void OnClick(){
        for(int i = 0; i < 10; i ++){
            GameObject card = Instantiate(eDeck[Random.Range(0, eDeck.Count)], new Vector2(0,0), Quaternion.identity);
            card.transform.SetParent(EnemyHand.transform, false);
            eDeck.RemoveAt(0);
        }
    }
    void Start()
    {
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

        Shuffle(eDeck);
    }
    
    public static List <GameObject> Shuffle(List<GameObject> deck)
    {
        List<GameObject> eDeck = new List<GameObject>();

        foreach(GameObject card in deck)
        {
            int position = Random.Range(0, deck.Count);
            eDeck.Add((position == eDeck.Count) ? card : deck[position]);
        }
        return eDeck;
    }  
    void Update()
    {
        
    }
}
