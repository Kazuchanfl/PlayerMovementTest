using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {
        // call Controller
        ControllCapsule();
    }

    // ControllCapsule is called to controll capsule object
    private void ControllCapsule() {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * 10f);
        }
    }
}
