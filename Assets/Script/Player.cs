using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float rotate;
    public GameObject player;
    private void Update()
    {
        player.transform.Rotate(0, 0, 45f);
    }
}
