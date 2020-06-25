using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Player_Base_HP = 10;
    public int Enemy_Base_HP = 10;
    public Text base_HP_Text;
    // Start is called before the first frame update
    void Start()
    {
        //FindObjectOfType<UnitSpawn>().Spawn_Player_Unit();
    }

    public void Dmg_Player()
    {
        Player_Base_HP--;
        if (Player_Base_HP == 0)
        {
            Debug.Log("Lose");
        }
    }
    public void Dmg_Player(int dmg)
    {
        Player_Base_HP -= dmg;
    }

    public void Dmg_Enemy()
    {
        Enemy_Base_HP--;
    }
    public void Dmg_Enemy(int dmg)
    {
        Enemy_Base_HP -= dmg;
    }

    private void Update()
    {
        base_HP_Text.text = "Base HP: " + Player_Base_HP;
    }
}
