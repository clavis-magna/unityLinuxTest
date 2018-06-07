using UnityEngine;
using System.Collections;

public class inputManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//print("1: " + Input.GetAxis("Fire1") + "2: " +Input.GetAxis("Fire2") + "3: " + Input.GetAxis("Fire3") + "Jump: " +Input.GetAxis("Jump"));
		print(Input.GetAxis("Horizontal"));
	
	}
}
