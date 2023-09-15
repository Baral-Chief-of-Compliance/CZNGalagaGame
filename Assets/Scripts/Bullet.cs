using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;

    void Update()
    {
        if (rb.position.y > 1.1f)
        {
            Destroy(gameObject);
        }
    }

}
