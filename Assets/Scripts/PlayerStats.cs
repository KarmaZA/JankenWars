using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int type = 0; //0 = Rock, 1 = paper, 2 = scissors
    public float damage = 1f;
    public float HP = 1f;

    public float GetDMG() { return damage; }
    public void SetDMG(float amount) { damage = amount; }
    public float GetHP() { return HP; }
    public void SetHP(float amount) { HP = amount; }
    public float GetUnitType() { return type; }


    public void damageCalc(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            float enType = collision.collider.GetComponent<EnemyStats>().GetUnitType();
            float enDMG = collision.collider.GetComponent<EnemyStats>().GetDMG();
            //Debug.Log(enType);
            //Making it work for Rock player
            if (enType == type)//draw
            {
                HP -= enDMG;
                collision.collider.GetComponent<EnemyStats>().DealDMG(damage);
            } else if (enType == (type + 1)) //lose
            {
                HP -= (enDMG + 1);
                collision.collider.GetComponent<EnemyStats>().DealDMG(damage -1);
            }
            else //win
            {
                HP -= (enDMG - 1);
                collision.collider.GetComponent<EnemyStats>().DealDMG(damage + 1);
            }
            if (HP < 1)
            {
                Debug.Log("player unit dead");
                Destroy(this.gameObject, 0f);
            }
        }
    }
}
