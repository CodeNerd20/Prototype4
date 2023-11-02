using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    private Rigidbody cannonBall;
    public float launchForce;
    public float forwardForce;

    // Start is called before the first frame update
    void Start()
    {
        cannonBall = GetComponent<Rigidbody>();
        cannonBall.AddForce(Vector3.up * launchForce + Vector3.forward * forwardForce, ForceMode.Impulse);
    }
}
