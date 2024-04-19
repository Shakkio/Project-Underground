using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetroTurboing : MonoBehaviour
{
    public float speedX = 1.0f; //how fast it shakes
    public float amountX = 1.0f; //how much it shakes

    public float speedY = 1.0f; //how fast it shakes
    public float amountY = 1.0f; //how much it shakes

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(Mathf.Sin(Time.time * speedX) * amountX, Mathf.Sin(Time.time * speedY) * amountY, transform.position.z);
    }
}
