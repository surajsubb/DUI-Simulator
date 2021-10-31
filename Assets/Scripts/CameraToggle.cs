using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggle : MonoBehaviour
{
    //This is Main Camera in the Scene
    public Camera m_MainCamera;
    //This is the second Camera and is assigned in inspector
    public Camera m_TopDownCamera;
    private bool isKeyPressed;

    private System.DateTime timeDelay;
    void Start()
    {
        //This gets the Main Camera from the Scene
        // m_MainCamera = Camera.main;
        //This enables Main Camera
        m_MainCamera.enabled = true;
        //Use this to disable secondary Camera
        m_TopDownCamera.enabled = false;
        isKeyPressed = false;
        
    }

    void Update()
    {
        //Press the L Button to switch cameras
        if (Input.GetKeyDown(KeyCode.L))
        {   
           
            m_TopDownCamera.enabled = true;

            //The Main first Camera is disabled
            m_MainCamera.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {   
            m_TopDownCamera.enabled = false;

            //The Main first Camera is disabled
            m_MainCamera.enabled = true;
        }
      
    }
}