using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSettings : MonoBehaviour
{
	public static Color paintColor = new Color(0.81f, 0.34f, 0.34f);
	public static string lastSelectedObjectName = "";
	public static bool isInTransformMode = false;
	private void Start() {
		GameObject.Find("TransformModeCheck").GetComponent<Image>().enabled = false;
	}
	
	private void Update() {
		if (GlobalSettings.isInTransformMode && GlobalSettings.lastSelectedObjectName != null) {
			GameObject go = GameObject.Find(GlobalSettings.lastSelectedObjectName);
			if (Input.GetKey(KeyCode.Alpha1)) {	
				go.transform.position += new Vector3(1,0,0) * 2 * Time.deltaTime;
			
			} else if (Input.GetKey(KeyCode.Alpha2)) {
				go.transform.position -= new Vector3(1,0,0) * 2 * Time.deltaTime;
			} else if (Input.GetKey(KeyCode.Alpha3)) {
				go.transform.position += new Vector3(0,1,0) * 2 * Time.deltaTime;
			} else if (Input.GetKey(KeyCode.Alpha4)) {
				go.transform.position -= new Vector3(0,1,0) * 2 * Time.deltaTime;
			} else if (Input.GetKey(KeyCode.Alpha5)) {
				go.transform.position += new Vector3(0,0,1) * 2 * Time.deltaTime;
			} else if (Input.GetKey(KeyCode.Alpha6)) {
				go.transform.position -= new Vector3(0,0,1)* 2 * Time.deltaTime;
			}

		}
	}
}
