using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandClass : MonoBehaviour
{
    private GameObject CardEntry;
     public List<GameObject> CardsatFrange;
     public int Cards = 0;
     public bool Surrender = false;

     private void OnCollisionEnter2D(Collision2D collision) // adds the cards to the list frange
     {
        CardEntry = collision.gameObject;
        if (!CardsatFrange.Contains(CardEntry))
        {
        CardsatFrange.Add(CardEntry);
        Cards ++;
        }
     }

    private void OnCollisionExit2D(Collision2D collision) // takes them out
     {
        if (CardsatFrange.Contains(CardEntry))
        {
        CardsatFrange.RemoveAt(0);
        Cards --;
        }
     }
}
