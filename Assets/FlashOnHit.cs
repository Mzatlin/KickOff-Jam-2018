using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashOnHit : MonoBehaviour {
    GameObject player;
   public SpriteRenderer render;
	// Use this for initialization
	void Start () {
       
      //  render = GetComponent<SpriteRenderer>();
        GetComponent<HitScript>().OnHit += HandleHit;
    }
	
    void HandleHit()
    {
        StartCoroutine(Flashing());
    }
    private IEnumerator Flashing()
    {
        render.enabled = false;
        yield return new WaitForSeconds(0.2f);
        render.enabled = true;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
