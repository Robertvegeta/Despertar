using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{

    public GameObject gameControllerObject;

    private GameController gameControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameControllerScript = gameControllerObject.GetComponent<GameController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // DO SOMETHING
    }

    // Detect Collision enter inside of collider.
    void OnTriggerEnter2D(Collider2D other)
    {
        gameControllerScript.detectCollider(other.transform.position);
    }

    // Detect Collision enter inside of collider.
    void OnTriggerExit2D(Collider2D other)
    {
        gameControllerScript.outsideCollider(other.transform.position);
    }



}
