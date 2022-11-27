using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject Gameover;
    public GameObject slash;
    public GameObject NextLevel;
    public AudioSource Sound;
    public bool infinite=false;
   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Obstacle" && infinite==false)
        {
           
            vibrationControl.Vibrate(25);
            Gameover.SetActive(true);
             Sound.Play();



            Debug.Log("Player Collide");
         Instantiate(slash, transform.position, Quaternion.identity);
            Destroy(gameObject);
           // Time.timeScale = 0;
        }
        else if(collision.gameObject.tag == "finish")
        {
            NextLevel.SetActive(true);
            Time.timeScale = 0;
          
            gameObject.SetActive(false);
          
        }
        else if (collision.gameObject.tag == "Obstacle")
        {
            NextLevel.SetActive(true);
            Time.timeScale =0;
           
            gameObject.SetActive(false);

        }

    }
}
