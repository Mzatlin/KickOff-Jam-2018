using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Grill : MonoBehaviour {
    PlayerManager m_player;
    public int damage;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        m_player = collision.gameObject.GetComponent<PlayerManager>();
        if (m_player != null)
        {
            PlayerManager.player.Health =- damage;
            Debug.Log(PlayerManager.player.Health);
        }
    }
}
