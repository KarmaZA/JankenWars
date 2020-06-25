using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickPaper : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(SpawnPaper);
    }

    public void SpawnPaper()
    {
        if (FindObjectOfType<Economy>().CheckPurchase(5))
        {
            FindObjectOfType<Economy>().SpendGold(5);
            FindObjectOfType<UnitSpawn>().Spawn_Player_Unit_Paper();
        }
        else
        {
            // not enough gold
            FindObjectOfType<Economy>().NotEnoughGold();
        }
    }
}
