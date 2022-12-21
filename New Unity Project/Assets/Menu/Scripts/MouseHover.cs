using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MouseHover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshPro>().color = new Color32(0,255,0,255);
    }

    void OnMouseEnter()
    {
        GetComponent<TextMeshPro>().color = new Color32(0,0,255,255);
    }

    void OnMouseExit()
    {
        GetComponent<TextMeshPro>().color = new Color32(0,255,0,255);
    }
}
