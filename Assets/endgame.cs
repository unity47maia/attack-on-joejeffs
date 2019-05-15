using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour {

    public GameObject winText;
    public GameObject loseText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "worldend")
        {
            //SceneManager.LoadLevel("Menu");
            Debug.Log("player wins");
            winText.SetActive(true);
        }
        else if (other.transform.tag == "joejeff")
        {
            //SceneManager.LoadLevel("Menu");
            Debug.Log("joejeff wins");
            loseText.SetActive(true);
        }
    }
}
