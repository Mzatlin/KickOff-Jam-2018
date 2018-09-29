using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrouch : MonoBehaviour {
    BoxCollider2D collider;
    Vector2 size;
    // Use this for initialization
    void Start () {
        collider = GetComponent<BoxCollider2D>();
        size = collider.size;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Crouch");
            collider.size = new Vector2(.1f, .1f);
        }
    }
}
