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
        CapsuleCollider cc = GetComponent<CapsuleCollider>();

        // Move right when Right Arrow is held down
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * 10f);
            print("right arrow key is held down");
        }

        // Move left when Left Arrow is held down
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * 10f);
            print("left arrow key is held down");
        }

        // Jump when Left Shift is held down
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (cc.enabled) {
                rb.AddForce(Vector3.up * 20f);
                print("left shift key is held down");
            }
        }
    }
}
