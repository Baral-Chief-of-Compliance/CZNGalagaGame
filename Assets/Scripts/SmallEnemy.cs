using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{
    public int live;
    public GameObject hitEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 0.4f);
        live = live - 1;
        if (live == 0)
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.4f);
            Destroy(gameObject);
        }
    }
}
