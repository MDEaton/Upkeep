using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {


    private int PlayerGold;
    private int PlayerLumber;
    private int PlayerFood;

    private static PlayerManager _instance;
    public static PlayerManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<PlayerManager>();

            return _instance;
        }
    }

    public void ChangeGold (int Amount)
    {
        PlayerGold += Amount;
        ResourceManager.Instance.UpdateGold(PlayerGold);
    }

    public void ChangeLumber(int Amount)
    {
        PlayerLumber += Amount;
        ResourceManager.Instance.UpdateGold(PlayerLumber);
    }

    public void ChangeFood(int Amount)
    {
        PlayerFood += Amount;
        ResourceManager.Instance.UpdateGold(PlayerFood);
    }
}
