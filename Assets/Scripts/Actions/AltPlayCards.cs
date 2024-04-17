using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.RestService;
using UnityEngine;
using UnityEngine.Android;

public class AltPlayCards : MonoBehaviour
{
    public GameObject Card; // card im bouta play
   public bool Turn = true; // i dont have turns yet but yk
   public bool playable = true; //bool to avoid playing the same card mult times
   public bool GameOver;
   public bool EnemySurrender;
   public bool PlayerSurrender;
   
   public GameObject PFMelee;
   public GameObject PFRange;
   public GameObject PFSiege;
   public GameObject EFMelee;
   public GameObject EFRange;
   public GameObject EFSiege;
   public GameObject pClimateMelee;
   public GameObject pClimateRange;
   public GameObject pClimateSiege;
   public GameObject eClimateMelee;
   public GameObject eClimateRange;
   public GameObject eClimateSiege;

   // private int CompPlayerCards = 0; //para comprobar las cartas de cada jugador
   // private int CompEnemyCards = 0;

   //private bool PlayerChooses; //los jugadores eligieron sus cartas
   // private bool EnemyChooses;
   private GameObject ShurimaHand; //player
   private GameObject ShadowIslesHand;  //enemy
   private GameObject pDeck;
   private GameObject eDeck;

    public void PlayCardsMethod()
{
        if (!GameOver)
        {
        PlayCardToZone(Card, PFMelee, 1, "Shurima");
        PlayCardToZone(Card, PFRange, 2, "Shurima");
        PlayCardToZone(Card, PFSiege, 3, "Shurima");
        PlayCardToZone(Card, pClimateMelee, 4, "Shurima");
        PlayCardToZone(Card, pClimateRange, 5, "Shurima");
        PlayCardToZone(Card, pClimateSiege, 6, "Shurima");

        PlayCardToZone(Card, EFMelee, 1, "Shadow Isles");
        PlayCardToZone(Card, EFRange, 2, "Shadow Isles");
        PlayCardToZone(Card, EFSiege, 3, "Shadow Isles");
        PlayCardToZone(Card, eClimateMelee, 4, "Shadow Isles");
        PlayCardToZone(Card, eClimateRange, 5, "Shadow Isles");
        PlayCardToZone(Card, eClimateSiege, 6, "Shadow Isles");
        }
}

private void PlayCardToZone(GameObject card, GameObject zone, int numericLine, string faction)
{
    if (card.transform.parent != zone.transform)
    {
        if (card.GetComponent<CardClass>().Faction == faction && card.GetComponent<CardClass>().NumericLine == numericLine /*&& Turn*/ && PlayerSurrender == false /*&& PlayerChooses*/)
        {
            if (playable)
            {
            card.transform.SetParent(zone.transform, false);
            card.transform.position = zone.transform.position;
            playable = false;
                
            // sound.Play();
            }
            else
            {
            playable = true;
            }
        }
    }

}

void Start()
    {
        PFMelee = GameObject.Find("PlayerMelee"); //busca las zonas, las manos y si la partida no ha terminado
        PFRange = GameObject.Find("PlayerRange");
        PFSiege = GameObject.Find("PlayerSiege");
        EFMelee = GameObject.Find("EnemyMelee");
        EFRange = GameObject.Find("EnemyRange");
        EFSiege = GameObject.Find("EnemySiege");
        pClimateMelee = GameObject.Find("pMeleeClimate");
        pClimateRange = GameObject.Find("pRangeClimate");
        pClimateSiege = GameObject.Find("pSiegeClimate");
        eClimateMelee = GameObject.Find("eMeleeClimate");
        eClimateRange = GameObject.Find("eRangeClimate");
        eClimateSiege = GameObject.Find("eSiegeClimate");
        ShurimaHand = GameObject.Find("PlayerHand");
        ShadowIslesHand = GameObject.Find("EnemyHand");
        GameOver = GameObject.Find("GameManager").GetComponent<GameManager>().GameOver;
        pDeck = GameObject.Find("PlayerDeck");
        eDeck = GameObject.Find("EnemyDeck");
        // sound = gameObject.GetComponent<AudioSource>();
    }
    
    public void CleanUpAfterGame()
    {
    // Destroy all cards in the player and enemy hands
    foreach (Transform child in ShurimaHand.transform)
    {
        Destroy(child.gameObject);
    }

    foreach (Transform child in ShadowIslesHand.transform)
    {
        Destroy(child.gameObject);
    }

    // Reset the playable variable
    playable = true;

    // Reset the game over variable
    GameOver = false;

    // Reset the player and enemy surrender variables
    PlayerSurrender = false;
    EnemySurrender = false;

    // Reset the player and enemy chooses variables
    //PlayerChooses = false;
    //EnemyChooses = false;

    // Reset the player and enemy decks
    pDeck = null;
    eDeck = null;
}

private void OnDisable()
    {
        CleanUpAfterGame();
    }

}



/*PlaySpyCard(Card, EFRange, 7);
        PlaySpyCard(Card, EFSiege, 8);

        PlayDecoyCard(Card, PFRange, 9);
        PlayDecoyCard(Card, PFSiege, 10);

        PlayDecoyCard(Card, EFMelee, 13);
        PlayDecoyCard(Card, EFRange, 14);*/

/* private void PlaySpyCard(GameObject card, GameObject zone, int numericLine)
{
    if (card.GetComponent<CardClass>().NumericLine == numericLine && Turn && PlayerSurrender == false && PlayerChooses)
    {
        if (playable)
        {
            card.transform.SetParent(zone.transform, false);
            card.transform.position = zone.transform.position;
            playable = false;
            // sound.Play();
        }
    }
}

private void PlayDecoyCard(GameObject card, GameObject zone, int numericLine)
{
    if (card.GetComponent<CardClass>().NumericLine == numericLine && Turn == false && EnemySurrender == false && EnemyChooses)
    {
        if (playable)
        {
            card.transform.SetParent(zone.transform, false);
            card.transform.position = zone.transform.position;
            playable = false;
            // sound.Play();
        }
    }
}*/

// public GameObject Cover1; //Cover the hands
   // public GameObject Cover2;

   //private List<GameObject> pDeck;
   //private List<GameObject> eDeck;
   // private int position= 0;