using UnityEngine;
using System.Collections;

public class distanceToCentreVolume : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		float howFar = Vector3.Distance(new Vector3(0,0,0), transform.position) - 440;
		if(howFar > 0)
		{
			GetComponent<AudioSource>().volume = howFar/100;
		}
		else
		{
			GetComponent<AudioSource>().volume = 0;
		}
	}
}
