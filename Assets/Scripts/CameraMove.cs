using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CameraMove : MonoBehaviour
{
    public Camera cam;
    public float moveSpeed = 5f;
    float move;
    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");
        
    }

    private void FixedUpdate()
    {
        if ((cam.transform.position.x > -18 && move < 0) || (move > 0 && cam.transform.position.x < 21))
        {
            cam.transform.Translate(new Vector3(moveSpeed * move * Time.fixedDeltaTime, 0, 0));
        }
    }
}
