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

    void Awake ()
    {
        UpdateResources();
    }

    private void UpdateResources ()
    {
        ResourceManager.Instance.UpdateGold(PlayerGold);
        ResourceManager.Instance.UpdateLumber(PlayerLumber);
        ResourceManager.Instance.UpdateFood(PlayerFood);
    }

    public void IncreaseResource (ResourceManager.ResourceType ResourceToUpdate, int Amount)
    {
        if( ResourceToUpdate == ResourceManager.ResourceType.gold )
        {
            PlayerGold += Amount;
            ResourceManager.Instance.UpdateGold(PlayerGold);
        }
        else if(ResourceToUpdate == ResourceManager.ResourceType.lumber)
        {
            PlayerLumber += Amount;
            ResourceManager.Instance.UpdateLumber(PlayerLumber);
        }
        else if (ResourceToUpdate == ResourceManager.ResourceType.food)
        {
            PlayerFood += Amount;
            ResourceManager.Instance.UpdateLumber(PlayerFood);
        }
    }

    /*public void IncreaseResource (ResourceManager.ResourceType ResourceToUpdate)
    {
        if (ResourceToUpdate == ResourceManager.ResourceType.gold)
        {
            PlayerGold++;
            ResourceManager.Instance.UpdateGold(PlayerGold);
        }
        else if (ResourceToUpdate == ResourceManager.ResourceType.lumber)
        {
            PlayerLumber++;
            ResourceManager.Instance.UpdateLumber(PlayerLumber);
        }
        else if (ResourceToUpdate == ResourceManager.ResourceType.food)
        {
            PlayerFood++;
            ResourceManager.Instance.UpdateLumber(PlayerFood);
        }
    }*/

    public void DecreaseResource(ResourceManager.ResourceType ResourceToUpdate, int Amount)
    {
        if (ResourceToUpdate == ResourceManager.ResourceType.gold)
        {
            PlayerGold -= Amount;
            ResourceManager.Instance.UpdateGold(PlayerGold);
        }
        else if (ResourceToUpdate == ResourceManager.ResourceType.lumber)
        {
            PlayerLumber -= Amount;
            ResourceManager.Instance.UpdateLumber(PlayerLumber);
        }
        else if (ResourceToUpdate == ResourceManager.ResourceType.food)
        {
            PlayerFood -= Amount;
            ResourceManager.Instance.UpdateLumber(PlayerFood);
        }
    }

    /*public void DecreaseResource(ResourceManager.ResourceType ResourceToUpdate)
    {
        if (ResourceToUpdate == ResourceManager.ResourceType.gold)
        {
            PlayerGold--;
            ResourceManager.Instance.UpdateGold(PlayerGold);
        }
        else if (ResourceToUpdate == ResourceManager.ResourceType.lumber)
        {
            PlayerLumber--;
            ResourceManager.Instance.UpdateLumber(PlayerLumber);
        }
        else if (ResourceToUpdate == ResourceManager.ResourceType.food)
        {
            PlayerFood--;
            ResourceManager.Instance.UpdateLumber(PlayerFood);
        }
    }*/
}
