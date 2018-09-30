using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
            
    }
    public void Play()
    {
        Debug.Log("Test Play");
        SceneManager.LoadScene("OpeningCutscene");
    }
    public void Credits()
    {
        Debug.Log("Test Credits");
        //SceneManager.LoadScene(credits);
    }
    public void Quit()
    {
        Debug.Log("Test Quit");
        Application.Quit();
       
    }
}
 

