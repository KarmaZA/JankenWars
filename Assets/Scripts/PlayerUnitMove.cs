using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(moveSpeed, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.x > 21)
        {
            Destroy(this.gameObject, 0f);
        }
    }
}
