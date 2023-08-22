using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    [SerializeField] int money;
    public TextMeshProUGUI moneyText;

    public void clickEvent()
    {
        money++;
    }

    void Update()
    {
        moneyText.text = money.ToString();
    }
}