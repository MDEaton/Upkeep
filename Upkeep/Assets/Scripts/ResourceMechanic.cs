using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceMechanic : BaseMechanic {

    ResourceManager.ResourceType ManagedResource = ResourceManager.ResourceType.gold;

    public void AcquireResource(int amount)
    {
        PlayerManager.Instance.IncreaseResource(ManagedResource,amount);
    }

    public void SpendResource(int amount)
    {
        PlayerManager.Instance.DecreaseResource(ManagedResource,amount);
    }

}
