using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodManager : MonoBehaviour
{
    public int food;
    public TextMeshProUGUI foodText;
    

    // Start is called before the first frame update
    void Start()
    {
        foodText.text = food.ToString();   
    }

    public void SpendFood()
    {
        if (food > 0)
        {
            food -= 1;
            foodText.text = food.ToString();
        }
    }

    public void GetFood()
    {
        if (MoneyManager.IsCanBuy == true)
        {
            food += 10;
            foodText.text = food.ToString();
        }
    }
}
