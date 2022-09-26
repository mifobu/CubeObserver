using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;

    // Update is called once per frame
    void FixedUpdate() {
        if (true) {
        rb.velocity = new Vector3(0, 0, 7);
        }

    }
}
