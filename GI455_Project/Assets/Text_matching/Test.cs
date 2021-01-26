using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public GameObject income, gotcha;
    public string[] Booker;
    public string numberone;

    public void Komadikap() 
    {
        numberone = income.GetComponent<Text>().text;
        for (int i = 0; i < Booker.Length; i++) 
        {
            if (numberone == Booker[i])
            {
                gotcha.GetComponent<Text>().text = "[" + numberone + " ]" + "is found.";
                break;

            }
            else 
            {
                gotcha.GetComponent<Text>().text = "[" + numberone + " ]" + "is not found.";

            }
        
        }


    }

    
    
}
