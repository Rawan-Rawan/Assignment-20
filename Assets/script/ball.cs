using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    float x = 0.01f;
    float y = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float newx = transform.position.x;
        float newy = transform.position.y;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            newx += x;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newx -= x;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newy += y;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newy -= y;
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            newx -= x;
            newy += y;
        }
        transform.position = new Vector3(newx, newy, transform.position.z);
    }
}