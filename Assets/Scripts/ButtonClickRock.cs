using System.Collections;
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
        FindObjectOfType<UnitSpawn>().Spawn_Player_Unit();
    }
}
