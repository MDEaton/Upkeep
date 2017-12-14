using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLock : MonoBehaviour {

    public UnlocksManager.UnlockStages UnlockedAt;

    void Start ()
    {
        if (UnlocksManager.Instance._CURRENTSTAGE >= UnlockedAt)
        {
            foreach ( Transform children in gameObject.transform )
            {
                children.gameObject.SetActive(true);
            }
                
        }
        else
        {
            foreach (Transform children in gameObject.transform)
            {
                children.gameObject.SetActive(false);
            }
        }
    }

    void FixedUpdate ()
    {
        if( !gameObject.activeInHierarchy )
        {
            if( UnlocksManager.Instance._CURRENTSTAGE >= UnlockedAt )
            {
                foreach (Transform children in gameObject.transform)
                {
                    children.gameObject.SetActive(true);
                }
            }
        }
    }
}
