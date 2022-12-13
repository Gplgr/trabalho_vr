using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorofObject : MonoBehaviour

{
	private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();

		GameObject[] objects = GameObject.FindGameObjectsWithTag("mytag");
         foreach (GameObject go in objects) {
			 string tag = RandomString(6, 6);
			//go.GetComponent<MeshRenderer>().tag = tag;
         }
    }



    void Update()
    {

    }
	
	private void OnMouseDown() {
		GameObject go = GameObject.Find(this.GetComponent<MeshRenderer>().name);
		Debug.Log(this.GetComponent<MeshRenderer>().name);
		go.GetComponent<MeshRenderer>().material.color = new Color(Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));;
	}
	
	private void OnMouseExit() {

	}



private string RandomString(int minCharAmount, int maxCharAmount)
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
	int charAmount = 6; //set those to the minimum and maximum length of your string
	string myString = "";
	for(int i=0; i<charAmount; i++)
	{
     myString += chars[Random.Range(0, chars.Length)];
	}
    return myString;
}


}
