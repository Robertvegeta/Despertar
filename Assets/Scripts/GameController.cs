using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Image character;

    private Vector3 targetPosition;
	// Use this for initialization
	void Start () {
        //targetPosition = character.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            //OR- Ray ray = Camera.main.ScreenPointToRay(new Vector3(posX, posY, 0));
            Vector3 targetPosition = Input.mousePosition;
            Debug.Log(targetPosition);

        }

       
        character.transform.position = Vector3.MoveTowards(character.transform.position, targetPosition, Time.deltaTime * 20);

    }
}
