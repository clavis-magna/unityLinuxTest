using UnityEngine;
using System.Collections;

public class TriggerSound : MonoBehaviour {

	void OnTriggerEnter(Collider other) 
	{
       	if(other.tag == "Player")
		{
			GetComponent<AudioSource>().Play();
		}		
	}
}
