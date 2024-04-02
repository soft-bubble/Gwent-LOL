using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pDrawCardsTester1 : MonoBehaviour
{
    public GameObject Card1;
    public GameObject PlayerHand;

    public void OnClick(){
        for(int i = 0; i < 10; i++){
            GameObject card = Instantiate(Card1, new Vector2(0,0), Quaternion.identity);
            card.transform.SetParent(PlayerHand.transform, false);
        }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
}
