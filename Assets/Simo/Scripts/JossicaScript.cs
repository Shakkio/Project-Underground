using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JossicaScript : MonoBehaviour
{
    public Vector3 PositionToStop;
    public float speed;
    public bool inPosition = false;
    
    Rigidbody rigidbody;
    public Vector3 direction;

    // Update is called once per frame

    private void Start()
    {
        transform.Rotate(0, 90, 0, 0);
        rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(inPosition == false)
        MoveToPosition();    
    }

    void MoveToPosition()
    {
        if(transform.position != PositionToStop)
        {
            direction = -Vector3.Normalize(transform.position - PositionToStop);
            rigidbody.AddForce(direction * speed);
        }
       
    }
}
