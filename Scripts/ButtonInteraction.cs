using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonInteraction : MonoBehaviour
{

    public TextMeshProUGUI simpleUIText; 

    public void OnButton1Clicked()
    {
        simpleUIText.text = "Button1 is clicked";
    }

    public void OnButton2Clicked()
    {
        simpleUIText.text = "Button2 is clicked";
    }


    public void OnButton3Clicked()
    {
        simpleUIText.text = "Button3 is clicked";
    }


}
