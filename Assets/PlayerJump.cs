using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {
    [SerializeField]
    Vector2 Jumpdirection;
    Rigidbody2D rb;
    bool isgrounded = true;
    // Use this for initialization
    void Start () {
        Jumpdirection = new Vector2(0, 10);
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.AddForce(Jumpdirection * 50);
          //  rb.velocity = new Vector2(0, 10);
            Debug.Log("Jumping");
          //  Vector2 targetvelocity = new Vector2(0, 50);

            isgrounded = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        isgrounded = true;
    }
}
