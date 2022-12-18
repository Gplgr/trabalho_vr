using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorofObject : MonoBehaviour

{
	private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
    }
    void Update()
    {

    }
	
	private void OnMouseDown() {
		GameObject go = GameObject.Find(this.GetComponent<MeshRenderer>().name);
		go.GetComponent<MeshRenderer>().material.color = GlobalColor.paintColor;
	}
	
	private void OnMouseExit() {

	}

}
