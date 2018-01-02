﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldMineManager : MonoBehaviour {

    float _ClickCooldown = 0f;
    float ClickTimer = 0f;

    int GoldRewardAmount = 1;
    int GoldMineLevel = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if( ClickTimer >= 0f )
        {
            ClickTimer -= Time.deltaTime;
        }
	}

    public void OnGoldClick ()
    {
        Debug.Log("Click Gold Mine");
        if( ClickTimer <= 0f)
        {
            int GoldEarned = GoldRewardAmount * GoldMineLevel;
            PlayerManager.Instance.IncreaseResource(ResourceManager.ResourceType.gold, GoldEarned);
            ClickTimer = _ClickCooldown;
        }
    }
}
