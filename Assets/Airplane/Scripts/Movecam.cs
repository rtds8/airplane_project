using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Movecam : MonoBehaviour
{
    // Start is called before the first frame update
    public CinemachineVirtualCamera currentCamera;
    public CinemachineBrain cBrain;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dolly = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
        dolly.m_PathPosition += 0.005f;
    }
}
