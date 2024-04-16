using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FringeClass : MonoBehaviour
{

    public List<GameObject> CardsinFringe;
    public int Cards = 0;
    public int Sum = 0;
    public Text punctuationText;
    public string Faction;
    public int Fringe;
    public GameObject ShurimaGrave;
    public GameObject ShadowIslesGrave;
    private GameObject PlayerHand;
    private GameObject EnemyHand;
    private GameObject CardEntry;
    private FringeClass PMP;
    private FringeClass PRP;
    private FringeClass PAP;
    private FringeClass EMP;
    private FringeClass ERP;
    private FringeClass EAP;
    private int CheckRound = 1;
    private int Round = 1;
    private int Halfsum = 0;

     private void OnCollisionEnter2D(Collision2D collision) //cuando colisionan mete las cartas en la lista de la franja 
    {
        CardEntry = collision.gameObject;
        CardsinFringe.Add(CardEntry);
        Cards ++;
    }
    void Update()
    {
        Round =  GameObject.Find("GameManager").GetComponent<GameManager>().Round;
        PlayerHand = GameObject.Find("PlayerHand");
        EnemyHand = GameObject.Find("EnemyHand");
        Cards = CardsinFringe.Count;
        PMP = GameObject.FindGameObjectWithTag("PlayerMelee").GetComponent<FringeClass>();  // find all fringes
        PRP = GameObject.FindGameObjectWithTag("PlayerDistance").GetComponent<FringeClass>(); 
        PAP = GameObject.FindGameObjectWithTag("PlayerSiege").GetComponent<FringeClass>(); 
        EMP = GameObject.FindGameObjectWithTag("EnemyMelee").GetComponent<FringeClass>(); 
        ERP = GameObject.FindGameObjectWithTag("EnemyDistance").GetComponent<FringeClass>(); 
        EAP = GameObject.FindGameObjectWithTag("EnemySiege").GetComponent<FringeClass>();  


        Halfsum = 0;
        for(int i = 0; i < CardsinFringe.Count; i++) // sum
        {
            Halfsum += CardsinFringe[i].GetComponent<CardClass>().Altered_Power;
        }
        Sum = Halfsum;
        punctuationText.text = Sum.ToString();  
    }
}
