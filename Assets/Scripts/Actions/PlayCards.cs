using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class PlayCards : MonoBehaviour
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

   // public GameObject Cover1; //Cover the hands
   // public GameObject Cover2;

   private List<GameObject> pDeck;
   private List<GameObject> eDeck;
   private int position= 0;

   private bool PlayerChooses; //los jugadores eligieron sus cartas
    private bool EnemyChooses;
   private int CompPlayerCards = 0; //para comprobar las cartas de cada jugador
   private int CompEnemyCards = 0;
   private GameObject ShurimaHand; //player
   private GameObject ShadowIslesHand;  //enemy

   public void PlayCardsMethod()
   {
        if (GameOver == false){
            {
        if(Card.GetComponent<CardClass>().Faction == "Shurima" && Card.GetComponent<CardClass>().NumericLine == 1 && Turn && PlayerSurrender == false && PlayerChooses)
        {
            if(playable) //si es la primera vez que se juega la carta se mueve a la franja correspondiente  y no se permite que se juegue de nuevo, se reproduce el audio
            {
            Card.transform.SetParent(PFMelee.transform, false);
            Card.transform.position = PFMelee.transform.position;
            playable = false;
            // sound.Play();
            }
        }

         if(Card.GetComponent<CardClass>().Faction == "Shurima" && Card.GetComponent<CardClass>().NumericLine == 2 && Turn && PlayerSurrender == false && PlayerChooses)
         {
            if(playable)//mismo proceso, distintas franjas
            {
                Card.transform.SetParent(PFRange.transform, false);
                Card.transform.position = PFRange.transform.position;
                playable = false;
                // sound.Play();
            }
         }

         if(Card.GetComponent<CardClass>().Faction == "Shurima" && Card.GetComponent<CardClass>().NumericLine == 3 && Turn && PlayerSurrender == false && PlayerChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(PFSiege.transform, false);
            Card.transform.position = PFSiege.transform.position;
            playable = false;
            // sound.Play();
            }   
         }

         if(Card.GetComponent<CardClass>().Faction == "Shurima" && Card.GetComponent<CardClass>().NumericLine == 4 && Turn && PlayerSurrender == false && PlayerChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(pClimateMelee.transform, true);
            Card.transform.position = pClimateMelee.transform.position;
             playable = false;
            // sound.Play();
            }   
         }

         if(Card.GetComponent<CardClass>().Faction == "Shurima" && Card.GetComponent<CardClass>().NumericLine == 5 && Turn && PlayerSurrender == false && PlayerChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(pClimateRange.transform, true);
            Card.transform.position = pClimateRange.transform.position;
             playable = false;
            // sound.Play();
            }   
         }

         if(Card.GetComponent<CardClass>().Faction == "Shurima" && Card.GetComponent<CardClass>().NumericLine == 6 && Turn && PlayerSurrender == false && PlayerChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(pClimateSiege.transform, true);
            Card.transform.position = pClimateSiege.transform.position;
             playable = false;
            // sound.Play();
            }   
         }



         if(Card.GetComponent<CardClass>().Faction == "Shadow Isles" && Card.GetComponent<CardClass>().NumericLine == 1 && Turn == false && EnemySurrender == false && EnemyChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(EFMelee.transform, false);
            Card.transform.position = EFMelee.transform.position;
             playable = false;
            // sound.Play();
            }   
         }

         if(Card.GetComponent<CardClass>().Faction == "Shadow Isles" && Card.GetComponent<CardClass>().NumericLine == 2 && Turn == false && EnemySurrender == false && EnemyChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(EFRange.transform, false);
            Card.transform.position = EFRange.transform.position;
             playable = false;
            // sound.Play();
            }   
         }

         if(Card.GetComponent<CardClass>().Faction == "Shadow Isles" && Card.GetComponent<CardClass>().NumericLine == 3 && Turn == false && EnemySurrender == false && EnemyChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(EFSiege.transform, false);
            Card.transform.position = EFSiege.transform.position;
             playable = false;
            // sound.Play();
            }   
         }

         if(Card.GetComponent<CardClass>().Faction == "Shadow Isles" && Card.GetComponent<CardClass>().NumericLine == 4 && Turn == false && EnemySurrender == false && EnemyChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(eClimateMelee.transform, true);
            Card.transform.position = eClimateMelee.transform.position;
             playable = false;
            // sound.Play();
            }   
         }

         if(Card.GetComponent<CardClass>().Faction == "Shadow Isles" && Card.GetComponent<CardClass>().NumericLine == 5 && Turn == false && EnemySurrender == false && EnemyChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(eClimateRange.transform, true);
            Card.transform.position = eClimateRange.transform.position;
             playable = false;
            // sound.Play();
            }   
         }

         if(Card.GetComponent<CardClass>().Faction == "Shadow Isles" && Card.GetComponent<CardClass>().NumericLine == 6 && Turn == false && EnemySurrender == false && EnemyChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(eClimateSiege.transform, true);
            Card.transform.position = eClimateSiege.transform.position;
             playable = false;
            // sound.Play();
            }   
         }

               //a partir de aqui es para jugar a la carta espia
         if(Card.GetComponent<CardClass>().NumericLine == 7 && Turn && PlayerSurrender == false && PlayerChooses)  
         {
            if(playable)
            {
            Card.transform.SetParent(EFRange.transform, false);
            Card.transform.position = EFRange.transform.position;
             playable = false;
            // sound.Play();
            }   
         }

         if(Card.GetComponent<CardClass>().NumericLine == 8 && Turn && PlayerSurrender == false && PlayerChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(EFSiege.transform, false);
            Card.transform.position = EFSiege.transform.position;
             playable = false;
            // sound.Play();
            }   
         }

         if(Card.GetComponent<CardClass>().NumericLine == 9 && Turn == false && EnemySurrender == false && EnemyChooses)
         {
            if(playable)
            {
                Card.transform.SetParent(PFRange.transform, false);
                Card.transform.position = PFRange.transform.position;
                playable = false;
            // sound.Play();
            }
         }

         if(Card.GetComponent<CardClass>().NumericLine == 10 && Turn == false && EnemySurrender == false && EnemyChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(PFSiege.transform, false);
            Card.transform.position = PFSiege.transform.position;
            playable = false;
            // sound.Play();
            }   
         }


               //y a partir de aqui es para jugar al sennuelo
         if(Card.GetComponent<CardClass>().NumericLine == 11 && Turn && PlayerSurrender == false && PlayerChooses)
        {
            if(playable)
            {
            Card.transform.SetParent(PFMelee.transform, false);
            Card.transform.position = PFMelee.transform.position;
            playable = false;
            // sound.Play();
            }
        } 

         if(Card.GetComponent<CardClass>().NumericLine == 12 && Turn && PlayerSurrender == false && PlayerChooses)
         {
            if(playable)
            {
                Card.transform.SetParent(PFRange.transform, false);
                Card.transform.position = PFRange.transform.position;
                playable = false;
            // sound.Play();
            }
         } 

         if(Card.GetComponent<CardClass>().NumericLine == 13 && Turn == false && EnemySurrender == false && EnemyChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(EFMelee.transform, false);
            Card.transform.position = EFMelee.transform.position;
             playable = false;
            // sound.Play();
            }   
         }

         if(Card.GetComponent<CardClass>().NumericLine == 14 && Turn == false && EnemySurrender == false && EnemyChooses)
         {
            if(playable)
            {
            Card.transform.SetParent(EFRange.transform, false);
            Card.transform.position = EFRange.transform.position;
             playable = false;
            // sound.Play();
            }   
         }
       } 
    }
   }
   public void pCheckRound()
    {
        position = Random.Range(0, pDeck.Count);
        if(pDeck[position].GetComponent<CardClass>().AlreadyDrewIt == false)
        {
            GameObject card = Instantiate(pDeck[position], new Vector2(0,0), Quaternion.identity);
            card.transform.SetParent(ShurimaHand.transform, false);
            pDeck[position].GetComponent<CardClass>().AlreadyDrewIt = true;
        }
        else
        {
            pCheckRound();
        }
    }
   public void eCheckRound() 
    {
        position = Random.Range(0, eDeck.Count);
        if(eDeck[position].GetComponent<CardClass>().AlreadyDrewIt == false)
        {
            GameObject card = Instantiate(eDeck[position], new Vector2(0,0), Quaternion.identity);
            card.transform.SetParent(ShadowIslesHand.transform, false);
            eDeck[position].GetComponent<CardClass>().AlreadyDrewIt = true;
        }
        else
        {
            eCheckRound();
        }
    }


   void Start()
    {
        PFMelee = GameObject.Find("PlayerMelee");//busca las zonas, las manos ,el sonido y si la partida no ha terminado
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
        // sound = gameObject.GetComponent<AudioSource>();
    }
   void Update()
    {
      ShurimaHand = GameObject.Find("PlayerHand");
      ShadowIslesHand = GameObject.Find("EnemyHand");
      //PlayerChooses = GameObject.Find("CartasGutts").GetComponent<GuttsCards>().GuttsSelected;
      //EnemyChooses = GameObject.Find("CartasGriffith").GetComponent<GriffCards>().GrifSelected;
      //Turn = GameObject.Find("TurnCounter").GetComponent<SetTurn>().Turno;
      pDeck = GameObject.Find("PlayerDeck").GetComponent<pDrawCards>().pDeck;
      eDeck = GameObject.Find("EnemyDeck").GetComponent<eDrawCards>().eDeck;
      EnemySurrender = GameObject.Find("EnemyHand").GetComponent<HandClass>().Surrender;
      PlayerSurrender = GameObject.Find("PlayerHand").GetComponent<HandClass>().Surrender;
        }
   }

