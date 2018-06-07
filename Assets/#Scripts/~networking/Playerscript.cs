using UnityEngine;
using System.Collections;

public class Playerscript : MonoBehaviour {

    public float speedMultiplier;
    
    void Start()
    {
    }

    void Update ()
    {
		GetComponent<Rigidbody>().AddForce((transform.forward * Input.GetAxis("Vertical")) * speedMultiplier);

        if (Input.GetButton ("Fire1"))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * speedMultiplier);
        }
    }

}