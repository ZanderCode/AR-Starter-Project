using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAlongXZ : MonoBehaviour
{

    public GameObject me;
    public float speedMultiplier = 0.5f;
    public float scaleSize = 10;

    Transform go;
    float newX = 0;
    float newZ = 0;


    void Start()
    {
        go = me.GetComponent<Transform>();
    }

    void Update()
    {   
        newX += Time.deltaTime * speedMultiplier;
        newZ += Time.deltaTime * speedMultiplier;
        float rotX = Mathf.Cos(newX);
        float rotZ = Mathf.Sin(newZ);
        go.transform.position = new Vector3(rotX*scaleSize,0,rotZ*scaleSize);
    }
}
