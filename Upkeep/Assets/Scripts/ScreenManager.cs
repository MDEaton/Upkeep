using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour {

    public enum ScreenStates { Kingdom = 0, GoldMine, Lumber, Farm };
    public ScreenStates CURRENTGAMESTATE = ScreenStates.Kingdom;

    public GameObject GoldMine, Lumber, Farm;

    private static ScreenManager _instance;
    public static ScreenManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<ScreenManager>();

            return _instance;
        }
    }

    void Awake()
    {
        ChangeScreen(ScreenStates.Kingdom);
    }

    public void ChangeScreen(ScreenStates DesiredState)
    {
        CURRENTGAMESTATE = DesiredState;
        UpdateState();
    }

    void UpdateState ()
    {
        if( CURRENTGAMESTATE == ScreenStates.Kingdom )
        {
            GoldMine.SetActive(false);
            Lumber.SetActive(false);
            Farm.SetActive(false);
        }
        else if( CURRENTGAMESTATE == ScreenStates.GoldMine )
        {
            GoldMine.SetActive(true);
        }
    }

}
