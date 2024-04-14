using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShurimaPoints : MonoBehaviour
{
    public Text ShurimaText;

    public GameObject PMP; //Player Melee Points
    public GameObject PRP; //Player Range(Distance) Points
    public GameObject PAP; //Player Siege(Asedio) Points 

    private int ShurimaSum = 0;

    void Update()
    {
        int ShurimaSumContainer = PMP.GetComponent<FringeClass>().Sum + PRP.GetComponent<FringeClass>().Sum + PAP.GetComponent<FringeClass>().Sum;
        ShurimaSum = ShurimaSumContainer;
        ShurimaText.text = ShurimaSum.ToString();
    }
}
