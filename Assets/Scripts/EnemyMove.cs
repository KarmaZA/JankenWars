using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(moveSpeed, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.x < -20)
        {
            FindObjectOfType<GameManager>().Dmg_Player();
        }
        rb.velocity = new Vector2(-1f, 0f);
        
    }
}
