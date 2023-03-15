using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class MoneyCounter : MonoBehaviour
{
    public Text moneyText;
    //[SerializeField] public Button buttonexit;
    public InputAction ExitbuttonAction;

    int dollarAmount;
    void Start()
    {
      dollarAmount = 0;
    }

 
    void Update()
    {
        ShowMoney();
          
         //if(dollarAmount >= 40)
         {
            //buttonexit.enabled = true;
           
         }
    }

    private void ShowMoney()
    {
        moneyText.text = dollarAmount.ToString();
    }

    public void AddMoney()
    {
        dollarAmount++; 
    }
}
