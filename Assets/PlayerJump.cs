using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {
    [SerializeField]
    Vector2 Jumpdirection;
    Rigidbody2D rb;
    bool isgrounded = true;
    public Animator animator;
    // Use this for initialization
    void Start () {
        Jumpdirection = new Vector2(0, 50);
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetBool("isJumping", true);
            rb.AddForce(Jumpdirection * 10);

            isgrounded = false;
            
        }
      
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        isgrounded = true;
        animator.SetBool("isJumping", false);
    }
}
