using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTest : MonoBehaviour {


    public TrackerHostSettings hostSettings;

    public string trackerAddress;
    public int trackerChannel;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 trackerPos =  hostSettings.GetPosition(trackerAddress, trackerChannel);
        print(trackerPos);
        Vector3 trackerPosFixed = new Vector3(trackerPos.x, 1.5f, -trackerPos.z);
        //Vector3 newVec = magicCube.position;
        // newVec = Vector3.Normalize(newVec);
        //otherCube.position = trackerPos + gameObject.transform.position;



        //print(newVec);
        if (trackerPosFixed.x > 1 || trackerPosFixed.z > 1 || trackerPosFixed.x < -1 || trackerPosFixed.z < -1)
        {
            transform.Translate(trackerPosFixed * Time.deltaTime * 0.5f);
        }
    }
}
