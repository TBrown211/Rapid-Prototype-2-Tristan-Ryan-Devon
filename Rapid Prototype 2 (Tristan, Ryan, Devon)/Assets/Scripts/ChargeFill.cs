using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeFill : MonoBehaviour
{
    public Image chargeBar;

    


    // Start is called before the first frame update
    void Start()
    {
        chargeBar = GetComponent<Image>();
    }

    // Update is called once per frame
    public void ChargeBar(float currentCharge, float maxCharge)
    {
        chargeBar.fillAmount = currentCharge / maxCharge;   
    }
}
