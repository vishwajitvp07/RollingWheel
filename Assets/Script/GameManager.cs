using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject pausepannel;
   public void level1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }
    public void unlock2()
    {


        if (3 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 3);
        }

    }
    public void unlock3()
    {


        if (4 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 4);
        }

    }
    public void unlock4()
    {


        if (5 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 5);
        }

    }
    public void unlock5()
    {


        if (6 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 6);
        }

    }
    public void unlock6()
    {


        if (7 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 7);
        }

    }
    public void unlock7()
    {


        if (8 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 8);
        }

    }
    public void unlock8()
    {


        if (9 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 9);
        }

    }
    public void unlock9()
    {


        if (10 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 10);
        }

    }
    public void unlock10()
    {


        if (11 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 11);
        }

    }
    public void select()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("select");
    }
    public void infinite()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("infinite");
    }
    public void level2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level2");
        if (3 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 3);
        }
    }
    public void level3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level3");
        if (4 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 4);
        }
    }
    public void level4()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level4");
        if (5 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 5);
        }
    }
    public void level5()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level5");

        if (6 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 6);
        }
    }
    public void level6()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level6");

        if (7 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 7);
        }
    }
    public void level7()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level7");

        if (8 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 8);
        }
    }
    public void level8()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level8");

        if (9 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 9);
        }
    }
    public void level9()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level9");

        if (10 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 10);
        }
    }

    public void level10()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level10");
        if (11 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 11);
        }
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
    public void Pause()
    {
        Time.timeScale = 0;
        pausepannel.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausepannel.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
