using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Timers;

public class GoToNextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("GoNextScene");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private IEnumerator GoNextScene()
    {
        yield return new WaitForSeconds(80.0f); // wait half a second
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex + 1);
                                                   
    }
}
