using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MainMenu : MonoBehaviour
{
    public bool isPreset;
    public bool isExit;
    public bool isCredits;
    public bool isReturn;

    void OnMouseUp()
    {
	if (isPreset)
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
	if (isCredits)
            Camera.main.transform.position = new Vector3(0.0f,20.0f,20.0f);
	if (isReturn)
            Camera.main.transform.position = new Vector3(0.0f,20.0f,0.0f);
	if (isExit)
	    Application.Quit();
    }

    void Update()
    {
        
    }
}
