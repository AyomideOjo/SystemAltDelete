using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class PlayerController : MonoBehaviour{

    // class variables
    Vector3 velocity;
    Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start(){
        myRigidbody = GetComponent<Rigidbody> ();
    }

    public void Move(Vector3 _velocity){
        velocity = _velocity;
    }

    public void LookAt(Vector3 lookPoint){
        Vector3 heightCorrectedPoint = new Vector3 (lookPoint.x, transform.position.y, lookPoint.z);
        transform.LookAt (heightCorrectedPoint);
    }

    // Update is called once per frame
    void FixedUpdate(){
        myRigidbody.MovePosition (myRigidbody.position + velocity * Time.fixedDeltaTime);
    }
}
