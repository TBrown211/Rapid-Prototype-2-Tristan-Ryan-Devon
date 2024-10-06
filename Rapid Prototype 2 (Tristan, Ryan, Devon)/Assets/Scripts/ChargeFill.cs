using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeFill : MonoBehaviour
{
    public Image chargeBar; //image variable to store the fill charge
                            //This script I got from watching a tutorial video online 
                            //https://www.youtube.com/watch?v=-UbElCzKwuA



    // Start is called before the first frame update
    void Start()
    {
        chargeBar = GetComponent<Image>();
    }

    // Update is called once per frame
    public void ChargeBar(float currentCharge, float maxCharge)
    {
        chargeBar.fillAmount = currentCharge / maxCharge;  //Makes sure to fill the charge bar amount by the current charge, 0
        //And divide that be the maximum amount of charge
    }
}
