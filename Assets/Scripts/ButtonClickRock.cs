﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickRock : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(SpawnRock);
    }

    public void SpawnRock()
    {
        if (FindObjectOfType<Economy>().CheckPurchase(5))
        {
            FindObjectOfType<Economy>().SpendGold(5);
            FindObjectOfType<UnitSpawn>().Spawn_Player_Unit_Rock();         
        } else
        {
            // not enough gold
            FindObjectOfType<Economy>().NotEnoughGold();
        }
    }
}
