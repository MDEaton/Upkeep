using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlocksManager : MonoBehaviour {

    public enum UnlockStages { start = 0, LumberUnlocked };
    public UnlockStages _CURRENTSTAGE = UnlockStages.start;

    private static UnlocksManager _instance;
    public static UnlocksManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<UnlocksManager>();

            return _instance;
        }
    }
}
