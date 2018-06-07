using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackerInDataArena : MonoBehaviour {

    public string trackerAddress;
    public int trackerChannel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(VRPN.vrpnTrackerQuat(trackerAddress, trackerChannel)); 
    }
}
