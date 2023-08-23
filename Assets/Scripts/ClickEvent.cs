using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickEvent : MonoBehaviour
{
    [SerializeField] int money;
    public TextMeshProUGUI moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
    }
    public void clickEvent()
    {
        money++;
        PlayerPrefs.SetInt("money", money);
    }

    public void ToAchievements()
    {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        moneyText.text = money.ToString();
    }
}