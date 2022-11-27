using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level_Manager : MonoBehaviour
{
    public Button[] Buttons;

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < Buttons.Length; i++)
        {
            if (i + 2 > levelAt)
                Buttons[i].interactable = false;
        }
    }
}
