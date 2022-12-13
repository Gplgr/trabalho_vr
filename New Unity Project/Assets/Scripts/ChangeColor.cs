using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
	[SerializeField]
	private GameObject sphere;
	
	private Renderer sphereRenderer;
	
	private Color newSphereColor;
	
	private float randomChannelOne, randomChannelTwo, randomChannelThree;
    // Start is called before the first frame update
    void Start()
    {
        sphereRenderer = sphere.GetComponent<Renderer>();
		gameObject.GetComponent<Button>().onClick.AddListener(ChangeColorSphere);
    }
	
	private void ChangeColorSphere() {
		randomChannelOne = Random.Range(0f,1f);
		randomChannelTwo = Random.Range(0f,1f);
		randomChannelThree = Random.Range(0f,1f);
		
		newSphereColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree);
		
		//sphereRenderer.material.SetColor("_Color", newSphereColor);
		
		Color color = Color.red;
         GameObject[] objects = GameObject.FindGameObjectsWithTag("mytag");
         foreach (GameObject go in objects) {
             MeshRenderer[] renderers = go.GetComponentsInChildren<MeshRenderer>();
             foreach (MeshRenderer r in renderers) {
                 foreach (Material m in r.materials) {
                     if (m.HasProperty("_Color"))
                         m.color = newSphereColor;
                 }
             }
         }
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
