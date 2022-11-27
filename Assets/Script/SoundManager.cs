using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    private static SoundManager Music;
    private void Awake()
    {
        if (Music == null)
        {
            Music = this;
            DontDestroyOnLoad(Music);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
