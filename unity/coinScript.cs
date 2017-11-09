using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// Create a collider-based trigger 
	void OnTriggerEnter(Collider other) // name the Collider "other" 
	{
		if  (other.name == "Player") // if other touches "Player" (named in our hierarchy) 
		{ 
			Destroy(gameObject); // then destroy gameObject (the coin) attached to other
		}
	}
}
