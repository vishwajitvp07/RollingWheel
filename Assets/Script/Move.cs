using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Touch touch;
    public float speedmodifier;
    public float movementSpeed = 5f;
    public float MaxSpeed;
    public GameObject instruction;
    public GameObject Level_Bar;
    public float Distance;
    void Start()
    {
        speedmodifier = 0.015f;
        
    }

    void Update()
    {
        if(Input.touchCount >0 && Time.timeScale==1)
        {
            touch = Input.GetTouch(0);

        }
        if(touch.phase == TouchPhase.Moved)
        {
            movementSpeed = movementSpeed + 0.08f * Time.deltaTime;
            transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedmodifier, transform.position.y, transform.position.z);
          
        }
        movementSpeed = movementSpeed + 0.04f * Time.deltaTime;
        transform.position += new Vector3(0, 0, movementSpeed * Time.deltaTime); ;
        if (movementSpeed >= MaxSpeed)
        {
            movementSpeed = MaxSpeed;
        }
        if (transform.position.z>40)
        {
            instruction.SetActive(false);
        }
        if (transform.position.z > Distance)
        {
            Level_Bar.SetActive(false);
        }


    }

}
