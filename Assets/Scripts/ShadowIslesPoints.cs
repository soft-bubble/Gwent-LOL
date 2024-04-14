using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShadowIslesPoints : MonoBehaviour
{
    public Text ShadowIslesText;

    public GameObject EMP; //Enemy Melee Points
    public GameObject ERP; //Enemy Range(Distance) Points
    public GameObject EAP; //Enemy Siege(Asedio) Points 

    private int ShadowIslesSum = 0;

    void Update()
    {
        int ShadowIslesContainer = EMP.GetComponent<FringeClass>().Sum + ERP.GetComponent<FringeClass>().Sum + EAP.GetComponent<FringeClass>().Sum;
        ShadowIslesSum = ShadowIslesContainer;
        ShadowIslesText.text = ShadowIslesSum.ToString();
    }
}
