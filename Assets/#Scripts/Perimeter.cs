using UnityEngine;
using System.Collections;

public class Perimeter : MonoBehaviour {

	 void OnTriggerEnter(Collider other) 
	{
       	if(other.tag == "boundary")
		{
			
			print("hit");

			transform.position = new Vector3(0,10,0);

		}
		
	}
}
