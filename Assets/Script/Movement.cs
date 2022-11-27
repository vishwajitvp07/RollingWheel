using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float SideSpeed;
    public GameObject Mainplayer;
    public float movementSpeed = 5f;
    private Rigidbody2D Character;
    private float Screenwidth;
    public float MaxSpeed;
    
    private void Start()
    {
        Screenwidth = Screen.width;
        Character = Mainplayer.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        int i = 0;
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > Screenwidth / 2)
            {
                Run(1.0f);

            }
            if (Input.GetTouch(i).position.x < Screenwidth / 2)
            {
                Run(-1.0f);

            }
            i++;
        }
    }
    private void Update()
    {
       movementSpeed = movementSpeed + 0.02f * Time.deltaTime;
        transform.position += new Vector3(0, 0, movementSpeed * Time.deltaTime); ;
        if (movementSpeed>=MaxSpeed)
        {
            movementSpeed = MaxSpeed;
        }
        
       
    }
    void Run(float horizontalInput)
    {

        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        transform.position += movement * Time.deltaTime * SideSpeed;
    }

}