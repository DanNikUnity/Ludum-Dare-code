using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floatingtext : MonoBehaviour
{
    Transform unit;
    public Transform worldSpaceCanvas;

    public Vector3 offset;


    void Start()
    {
        unit = transform.parent;
        transform.SetParent(worldSpaceCanvas);

    }

    void Update()
    {
        transform.position = unit.position + offset;
    }
}
