using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandClass : MonoBehaviour
{
     private GameObject CardEntry;
     public List<GameObject> CardsatFringe;
     public int Cards = 0;
     public int CardsSentBack = 0;
     public bool Surrender = false;

     private void OnCollisionEnter2D(Collision2D collision) // adds the cards to the list frange
     {
        CardEntry = collision.gameObject;
        if (!CardsatFringe.Contains(CardEntry))
        {
        CardsatFringe.Add(CardEntry);
        Cards ++;
        }
     }

    private void OnCollisionExit2D(Collision2D collision) // takes them out
     {
        if (CardsatFringe.Contains(CardEntry))
        {
        CardsatFringe.RemoveAt(0);
        Cards --;
        }
     }
}
