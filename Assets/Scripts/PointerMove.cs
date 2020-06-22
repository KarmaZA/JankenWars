using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerMove : MonoBehaviour
{
    public Transform trans;
    float move;
    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        if ((trans.transform.position.y > -6.5 && move < 0) || (move > 0 && trans.transform.position.y < 6.5))
        {
            trans.transform.Translate(new Vector3(0, move * Time.fixedDeltaTime*5, 0));
        }
    }

    public float GetYAxis()
    {
        return trans.transform.position.y;
    }

}
