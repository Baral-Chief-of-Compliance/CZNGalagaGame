using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CZNShipMovment : MonoBehaviour
{

    public Camera cam;
    public float speed = 5f;
    public Rigidbody2D rb;

    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = 0;

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position  + mousePos * speed * Time.fixedDeltaTime);
    }
}
