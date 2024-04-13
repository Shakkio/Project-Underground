using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.Animations;

public class CameraControl : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Maybe make this smoother idk fucking gl
        if(Input.GetKeyDown(KeyCode.E)) {
            virtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>().m_FollowOffset = new Vector3(Mathf.PI, 5, 5);
        }   

        if(Input.GetKeyDown(KeyCode.Q)) {
            virtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>().m_FollowOffset = new Vector3(-Mathf.PI, 5, 5);
        }   
        
    }
}
