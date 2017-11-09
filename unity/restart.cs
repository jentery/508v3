using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	} 
  // create a trigger-based collider 
	void OnTriggerEnter(Collider other) { // call the collider "other" 
	SceneManager.LoadScene ("level1"); // on collision, load scene "level1" 
	}
}
