using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<UnitSpawn>().Spawn_Player_Unit(-0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
