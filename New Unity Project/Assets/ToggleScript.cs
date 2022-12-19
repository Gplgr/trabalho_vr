using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
	Toggle m_Toggle;
    // Start is called before the first frame update
    void Start()
    {
			m_Toggle = GetComponent<Toggle>();
			m_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(m_Toggle);
        });
    }
	
	void ToggleValueChanged(Toggle change)
    {
		GameObject.Find("TransformModeCheck").GetComponent<Image>().enabled = m_Toggle.isOn;
		GlobalSettings.isInTransformMode = m_Toggle.isOn;	
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
