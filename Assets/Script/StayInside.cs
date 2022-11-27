using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5f,5f), transform.position.y, transform.position.z);  
    }
}
