using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawn : MonoBehaviour
{
    public GameObject Player_Unit_Rock;
    public GameObject Player_Unit_Paper;
    public GameObject Player_Unit_Scissors;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn_Player_Unit_Rock()
    {
        float ypos = FindObjectOfType<PointerMove>().GetYAxis();
        Instantiate(Player_Unit_Rock, new Vector2(-20, ypos), Quaternion.identity);
    }

    public void Spawn_Player_Unit_Paper()
    {
        float ypos = FindObjectOfType<PointerMove>().GetYAxis();
        Instantiate(Player_Unit_Paper, new Vector2(-20, ypos), Quaternion.identity);
    }
    public void Spawn_Player_Unit_Scissors()
    {
        float ypos = FindObjectOfType<PointerMove>().GetYAxis();
        Instantiate(Player_Unit_Scissors, new Vector2(-20, ypos), Quaternion.identity);
    }
}
