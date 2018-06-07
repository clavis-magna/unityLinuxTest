using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distributePoints : MonoBehaviour {

    public GameObject aPoint;

    // Use this for initialization
    void Start () {
		for(int x = - 100; x < 100; x = x + 2)
        {
            for (int z = -100; z < 100; z = z + 2)
            {
                Instantiate(aPoint, new Vector3(x, Random.Range(0,20), z), Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
