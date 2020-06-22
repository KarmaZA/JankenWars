using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Player_Base_HP = 10;
    public int Enemy_Base_HP = 10;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<UnitSpawn>().Spawn_Player_Unit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dmg_Player()
    {
        Player_Base_HP--;
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
}
