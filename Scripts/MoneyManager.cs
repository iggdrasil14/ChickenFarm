using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    private static bool isCanBuy;
    public static bool IsCanBuy
    {
        get 
        {
            bool r = isCanBuy;
            isCanBuy = false;
            return r;
        }
        private set => isCanBuy = value;
    }
    public int money;
    public TextMeshProUGUI textMoney;

    // Start is called before the first frame update
    void Start()
    {
        textMoney.text = money.ToString();
    }

    public void SpendMoney(int spendMoney)              // Метод траты денег.
    {
        if (money >= spendMoney)
        {
            money -= spendMoney;
            textMoney.text = money.ToString();
            IsCanBuy = true;
        }
    }

    public void SetMoney(int setMoney)                 // Метод получения денег.
    {
        if (setMoney > 0)
        {
            money += setMoney;
            textMoney.text = money.ToString();
        }
    }

    public void SellChicken()
    {
        AnimalStadiaChicken[] chickenToSell = FindObjectsOfType<AnimalStadiaChicken>();
        AnimalStadiaChicken randomChicken = chickenToSell[Random.Range(0, chickenToSell.Length)];
        Destroy(randomChicken.gameObject);
        SetMoney(250);
    }

}
