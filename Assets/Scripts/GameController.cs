using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Image character;

    private Vector3 targetPosition;
    private Vector3 lastTargetPosition;
    private bool insideCollider;
   
	// Use this for initialization
	void Start () {
        insideCollider = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        // Vamos hacía el objetivo clicado siempre y cuando no haya collider
        if (!insideCollider)
        {
            character.transform.position = Vector3.MoveTowards(
                    new Vector3(character.transform.position.x, character.transform.position.y, 0),
                    new Vector3(targetPosition.x, targetPosition.y, 0),
                    Time.deltaTime * 20);

            lastTargetPosition = character.transform.position;
        }
        else {

            // Hacemos moon walker para irnos del collider.
            character.transform.position = Vector3.MoveTowards(
                    new Vector3(character.transform.position.x, character.transform.position.y, 0),
                    new Vector3(-targetPosition.x, -targetPosition.y, 0),
                    Time.deltaTime * 20);
        }
    }

    // Evento que se ejecutara remotamente cuando el personaje toque un collider
    public void detectCollider(Vector3 collider)
    {
        insideCollider = true;
        targetPosition = collider;
    }

    // Evento que se ejecutara remotamente cuando el personaje salga de un collider
    public void outsideCollider(Vector3 collider)
    {
        insideCollider = false;
        targetPosition = character.transform.position;
    }

    

}
