using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovment : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    public GameObject spaceBlock;

    Vector2 movment;


    // Update is called once per frame
    void Update()
    {
        movment.x = 0;
        movment.y = -1;
        if (rb.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movment * speed * Time.fixedDeltaTime);
    }

}
