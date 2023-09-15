using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    public GameObject spaceTile;
    public Transform startPoint;
    private GameObject space;
    // Start is called before the first frame update
    void Start()
    {
        space = Instantiate(spaceTile, startPoint);
    }

    // Update is called once per frame
    void Update()
    {
        if (space.transform.position.y < -0.3f)
        {
            space = Instantiate(spaceTile, startPoint);
        }

    }
}
