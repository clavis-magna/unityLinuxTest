using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    public float speedMultiplier;

    void Update()
    {
        print(Input.GetAxis("Vertical"));
        GetComponent<Rigidbody>().AddForce((transform.forward * Input.GetAxis("Vertical"))*speedMultiplier);
    }

    void OnTriggerEnter (Collider other) 
    {
        print("i hit: " + other);
    }

}

