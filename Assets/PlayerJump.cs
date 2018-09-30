using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {
    [SerializeField]
    Vector2 Jumpdirection;
    Rigidbody2D rb;
    bool isgrounded = true;
    CircleCollider2D circle;
    public float fallmultiplier = 2.5f;
    public float lowjumpmultiplier = 2f;
    RaycastHit hit;
    float distance = 1f;
    Vector3 dir = new Vector3(0, -1);


    // Use this for initialization
    void Start () {
        Jumpdirection = new Vector2(0, 10);
        rb = GetComponent<Rigidbody2D>();
        circle = GetComponent<CircleCollider2D>();
        
    }
	
	// Update is called once per frame
	void Update () {
  /*      if (Physics.Raycast(transform.position, dir, out hit, distance))
        {
            isgrounded = true;
        }
        else
        {
            isgrounded = false;
        }*/

        if (Input.GetKeyDown(KeyCode.Mouse0)&&isgrounded)
        {
                rb.AddForce(Jumpdirection * 50);
            //  rb.AddForce(Vector2.up * 100);
            // rb.velocity = Vector2.up*100;
            //   GetComponent<Rigidbody2D>().velocity = Vector2.up * 100f;
            /*   if (rb.velocity.y < 0)
               {
                   rb.velocity += Vector2.up * Physics2D.gravity.y * (fallmultiplier - 1) * Time.deltaTime;
                   Debug.Log("Jumping");
               }*/
          

            isgrounded = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //   if (collision.collider.bounds.Intersects(circle.bounds))
        //   {
        if (collision.gameObject != null)
        {
            isgrounded = true;
            Debug.Log("True");
        }
     //   }
    
    }
}
