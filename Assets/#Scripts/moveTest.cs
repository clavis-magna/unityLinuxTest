using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTest : MonoBehaviour {

    public Transform magicCube;
    public Transform otherCube;

    public string trackerAddress;
    public int trackerChannel;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 trackerPos = VRPN.vrpnTrackerPos(trackerAddress, trackerChannel);
        //Vector3 newVec = magicCube.position;
       // newVec = Vector3.Normalize(newVec);
        //otherCube.position = trackerPos + gameObject.transform.position;
        
        //print(newVec);
        transform.Translate(trackerPos * Time.deltaTime  * 0.5f);    }
}
