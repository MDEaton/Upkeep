using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMechanic : MonoBehaviour {

    public GameObject[] ObjectsToUnlock;


	public void UnlockMechanic ()
    {
        foreach( GameObject LockedObject in ObjectsToUnlock)
        {
            if(LockedObject.activeInHierarchy == false)
            {
                LockedObject.SetActive(true);
            }
        }
    }
}
