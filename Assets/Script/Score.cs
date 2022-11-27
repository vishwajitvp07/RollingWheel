using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoretext;
    float Score1;

    private void Update()
    {
        Score1 += 2 * Time.deltaTime;

        scoretext.text = "Score: " + (int)Score1;


        if (PlayerPrefs.GetInt("BestScore") < Score1)
        {
            PlayerPrefs.SetInt("BestScore", (int)Score1);
        }
    }
}
