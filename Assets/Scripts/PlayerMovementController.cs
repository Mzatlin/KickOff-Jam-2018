using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {
    Rigidbody2D rb;
    [SerializeField]
    Vector2 Jumpdirection;
    bool isgrounded;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Jumpdirection = new Vector2(0, 30);
    }

    // Update is called once per frame
    void Update()
    {
        moveplayer();


        if (Input.GetKeyDown(KeyCode.Mouse0)) { 

            rb.AddForce(Jumpdirection * 10);
            isgrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Crouch");
        }

    }
    void moveplayer()
    {
        rb.velocity = new Vector2(1*(PlayerManager.player.Speed * Time.deltaTime), 0);
    }
}

