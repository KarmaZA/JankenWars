using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Economy : MonoBehaviour
{
    /*
     * This class deals with the gold of the game
     * add, subtract and check if you have enough for a purchase
     * 
     * 
     * 
     */
    public int gold = 50;
    public float Passive_wait_timer = 5f;
    public Text text;

    private void Update()
    {
        text.text = "Gold: " + gold;
    }

    void Start()
    {
        StartCoroutine(Passive_Income());
    }

    IEnumerator Passive_Income()
    {
        yield return new WaitForSeconds(Passive_wait_timer);
        AddGold();
        StartCoroutine(Passive_Income());
    }

    public Boolean CheckPurchase(int amount)
    {
        if (amount >= gold)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public void AddGold()
    {
        gold++;
    }

    public void AddGold(int amount)
    {
        gold += amount;
    }

    public void SpendGold()
    {
        gold--;
    }

    public void SpendGold(int amount)
    {
        gold -= amount;
    }
}
