using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class hoverObject : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public string objectName;
    public Text infoText;

    private string lastText;

    // Use this for initialization
    void Start () {
        this.lastText = infoText.text;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Object name: " + this.name);
        infoText.text = objectName;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Object name: " + this.name);
        infoText.text = objectName;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        infoText.text = lastText;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("Hover object");
    }
}
