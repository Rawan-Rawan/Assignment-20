using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class danger : MonoBehaviour
{
    public float rotationDegree = 0f;
    public float increaseRotationDegree = 1f;
    public float zmin = 144f;
    public float zmax = 148f;
    float direction = 4f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotationDegree += increaseRotationDegree;
        transform.rotation = Quaternion.Euler(new Vector3(0, rotationDegree, 0));

        float newz = transform.position.z + direction;
        if (newz >= zmax)
        {
            newz = zmax;
            direction = -1f;
        }
        else if (newz <= zmin)
        {
            newz = zmin;
            direction = 1f;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, newz);
    }
}
