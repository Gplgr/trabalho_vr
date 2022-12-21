using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject[] pauseObjects;
    [SerializeField] GameObject[] customObjects;

    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        customObjects = GameObject.FindGameObjectsWithTag("ShowOnCustom");
        hidePaused();
        hideCustom();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                hidePaused();
            }
        }
    }

    public void Reload()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    public void Custom()
    {
        showCustom();
    }
   
    public void Menu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void pauseControl()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    public void returnPause()
    {
        hideCustom();
    }

    public void showPaused()
    {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    public void hidePaused()
    {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    public void showCustom()
    {
        foreach(GameObject g in customObjects)
        {
            g.SetActive(true);
        }
    }

    public void hideCustom()
    {
        foreach(GameObject g in customObjects)
        {
            g.SetActive(false);
        }
    }
}