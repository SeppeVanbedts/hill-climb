using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public Transform target;
    public int offset = 10;
    public int offsety = 1;
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = target.position;
        pos.z = -offset;
        pos.y = -offsety;
        transform.position = pos;

      
    }
}
