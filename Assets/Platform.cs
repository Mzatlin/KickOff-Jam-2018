using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {
    [SerializeField]
    PlatformGenerator platform;
    [SerializeField]
    int random;
    GameObject obstacleposition;
	// Use this for initialization
	void Start () {
        platform = FindObjectOfType<PlatformGenerator>();
        random = Random.Range(0, platform.obstacles.Capacity);
        obstacleposition = platform.obstacles[random];
        Instantiate(obstacleposition);
        obstacleposition.transform.position = new Vector3(transform.position.x, transform.position.y + .156f, transform.position.z);
        
	}
	
	// Update is called once per rame
	void Update () {
		
	}
}
