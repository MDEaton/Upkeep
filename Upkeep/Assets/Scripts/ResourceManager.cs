using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour {

    public Text GoldField, LumberField, FoodField;

    private static ResourceManager _instance;
    public static ResourceManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<ResourceManager>();

            return _instance;
        }
    }

    void Awake()
    {
    }

    public void UpdateGold (int CurrentGold)
    {
        GoldField.text = CurrentGold.ToString();
    }

    public void UpdateLumber(int CurrentLumber)
    {
        LumberField.text = CurrentLumber.ToString();
    }

    public void UpdateFood(int CurrentFood)
    {
        FoodField.text = CurrentFood.ToString();
    }
}
