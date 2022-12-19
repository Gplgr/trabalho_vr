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
		GlobalSettings.lastSelectedObjectName = this.GetComponent<MeshRenderer>().name;
		if (GlobalSettings.isInTransformMode == false) {
			GameObject go = GameObject.Find(this.GetComponent<MeshRenderer>().name);
			go.GetComponent<MeshRenderer>().material.color = GlobalSettings.paintColor;
			
		}
	}
	
	private void OnMouseExit() {

	}

}
