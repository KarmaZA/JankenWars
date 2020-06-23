using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float Spawn_Interval = 3f;

    public GameObject Rock;
    public GameObject Paper;
    public GameObject Scissors;

    void Start()
    {
        StartCoroutine(callSpawn());
    }

    IEnumerator callSpawn()
    {
        yield return new WaitForSeconds(Spawn_Interval);
        Spawn();
        StartCoroutine(callSpawn());
    }
    private void Spawn()
    {
        float ypos = Random.Range(-6.5f, 5.6f);
        float type = Random.Range(0, 3);
        if(type < 1)
        {
            Instantiate(Rock, new Vector2(20, ypos), Quaternion.identity);
        } else if (type < 2)
        {
            Instantiate(Paper, new Vector2(20, ypos), Quaternion.identity);
        } else
        {
            Instantiate(Scissors, new Vector2(20, ypos), Quaternion.identity);
        }
    }
}
