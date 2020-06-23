using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int type = 0; //0 = Rock, 1 = paper, 2 = scissors
    public float damage = 1f;
    public float HP = 1f;

    public float GetDMG() { return damage; }
    public void SetDMG(float amount) { damage = amount; }
    public float GetHP() { return HP; }
    public void SetHP(float amount) { HP = amount; }
    public float GetUnitType() { return type; }

    public void DealDMG(float amount)
    {
        HP -= amount;
        if(HP < 1)
        {
            Debug.Log("Dead");
            Destroy(this.gameObject, 0f);
        }
    }

}
