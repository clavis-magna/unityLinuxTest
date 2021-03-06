﻿using System.Collections;
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
        Vector3 trackerPosFixed = new Vector3(-trackerPos.x, 1.5f, trackerPos.z);
        //Vector3 newVec = magicCube.position;
        // newVec = Vector3.Normalize(newVec);
        Vector3 whereToHeadTo = trackerPosFixed + gameObject.transform.position;
        Vector3 whereToHeadFixed = new Vector3(whereToHeadTo.x, 1.5f, whereToHeadTo.z);



        //print(newVec);
        if (trackerPosFixed.x > 0.4f || trackerPosFixed.z > 0.4f || trackerPosFixed.x < -0.4f || trackerPosFixed.z < -0.4f)
        {
            //transform.Translate(trackerPosFixed * Time.deltaTime * 0.5f);
            transform.position = Vector3.MoveTowards(transform.position, whereToHeadFixed, Time.deltaTime * 1.5f);
        }
    }
}
