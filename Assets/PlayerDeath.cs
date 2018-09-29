using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponentInParent<PlayerManager>().OnDie += HandleDie;
        GetComponentInParent<HitScript>().OnDie += HandleDie;
    }
	void HandleDie()
    {
        Debug.Log("you died!");
        
    }
	// Update is called once per frame
	void Update () {
		
	}
}
