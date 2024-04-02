using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CardClass : MonoBehaviour
{              
    public string Name; // Name of the card
    public int Initial_Power; // Original power of the card without any effect
    public int Altered_Power; // Altered power of the card under any effect
    public string Skill; // Skill description if it has one
    public string Faction; //Faction in which it fights
    public string Medal; // Whether its a gold hero or a silver hero
    public string Line; // Which line does it plays between M/R/A
    public bool GrowthAffected; // If its under the influence of a Growth card
    public bool ClimateAffected; // If its under the influence of a Climate card
    public bool AlreadyDrewIt = false; 

}
