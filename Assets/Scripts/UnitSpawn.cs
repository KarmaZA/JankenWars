using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawn : MonoBehaviour
{
    public GameObject Player_Unit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn_Player_Unit(float ypos)
    {
        Instantiate(Player_Unit, new Vector2(-20, ypos), Quaternion.identity);
    }
}
