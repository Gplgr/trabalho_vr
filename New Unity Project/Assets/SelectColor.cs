using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectColor : MonoBehaviour
{
	private void Start() {
		GameObject go = GameObject.Find("CurrentColor");
		go.GetComponent<Image>().color = GlobalSettings.paintColor;
	}
	
	private void Update() {
		
		if (EventSystem.current != null && EventSystem.current.currentSelectedGameObject != null) {
			GameObject currentGo = EventSystem.current.currentSelectedGameObject;
			string goName = currentGo.name;

			
			
			if (!GlobalSettings.isInTransformMode) {
				if (goName == "RedBtn") {
					GlobalSettings.paintColor = new Color(0.81f, 0.34f, 0.34f);
				
				} else if (goName == "BlueBtn") {
					GlobalSettings.paintColor = new Color(0.27f, 0.74f, 0.81f);
				} else if (goName == "YellowBtn") {
					GlobalSettings.paintColor = new Color(0.95f, 0.87f, 0.41f);
				} else if (goName == "GreenBtn") {
					GlobalSettings.paintColor = new Color(0.31f, 0.8f, 0.29f);
				}
					GameObject go = GameObject.Find("CurrentColor");
					go.GetComponent<Image>().color = GlobalSettings.paintColor;
			}
			


			
		}
	}

}
