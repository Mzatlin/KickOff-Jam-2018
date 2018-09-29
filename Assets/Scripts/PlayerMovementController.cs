using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Debug.Log(PlayerManager.player.Health);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Jump");

        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Crouch");
        }
    }
}

