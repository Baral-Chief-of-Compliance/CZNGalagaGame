using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportShip : MonoBehaviour
{
    public Transform anotherSIde;
    public float distance = 0.2f;
    public bool left;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Vector2.Distance(collision.transform.position, transform.position) > distance)
        {
            collision.transform.position = anotherSIde.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (left)
        {
            if (Vector2.Distance(collision.transform.position, transform.position) > distance)
            {
                collision.transform.position = anotherSIde.position;
            }
        }
    }
}
