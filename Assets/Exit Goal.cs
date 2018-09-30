using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGoal : MonoBehaviour {
    PlayerManager m_player;
	// Use this for initialization
	void Start () {
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        m_player = collision.gameObject.GetComponent<PlayerManager>();
        if (m_player != null)
        {
            Debug.Log("Touched!");
            SceneManager.LoadScene("MainMenu");
        }
        }
}
