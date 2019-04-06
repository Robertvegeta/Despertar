using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class move : MonoBehaviour
{

    public Image user;

    // Use this for initialization
    void Start () {

        //Debug.Log("User in position: " + user.transform.position);
    }
	
	// Update is called once per frame
	void Update () {

        /*if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Clicked in: " + Input.mousePosition);
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            user.transform.position = Vector3.MoveTowards(user.transform.position, targetPosition, Time.deltaTime * 5);
            //Debug.Log("mouse click");
        }*/

    }

    public void OnMouseDown()
    {
        Debug.Log("OnMouseDown.");
    }
}
