using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HitScript : MonoBehaviour {
    Grill grill;
    public event Action OnHit = delegate { };
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {

       grill = collision.gameObject.GetComponent<Grill>();

         if (grill != null)
        {
            PlayerManager.player.Health -= grill.damage;
            Debug.Log(PlayerManager.player.Health);
            OnHit();
        }
    }
}
