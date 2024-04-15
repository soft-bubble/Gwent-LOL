using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FringeClass : MonoBehaviour
{
    private GameObject CardEntry;
    public List<GameObject> CardsinFrange;
    public int Cards = 0;
    public int Sum = 0;

    public Text puntuationText;
    public string Faction;
    public int Fringe;
    public GameObject ShurimaGrave;
    public GameObject ShadowIslesGrave;
    public GameObject PlayerHand;
    public GameObject EnemyHand;

    private int CheckRound = 1;
    private int Round = 1;
    private int sumaparcial = 0;

     private void OnCollisionEnter2D(Collision2D collision) //cuando colisionan mete las cartas en la lista de la franja 
    {
        CardEntry = collision.gameObject;
        CardsinFrange.Add(CardEntry);
        Cards ++;
    }
}
