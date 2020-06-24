using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCollision : MonoBehaviour
{
    //This Scrpit will go on the player unit
    //and on collision with the enemy is will proc all necessary collision things.

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            //Do stuff
            this.gameObject.GetComponent<PlayerStats>().damageCalc(collision);
        }
    }
}
