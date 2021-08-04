using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroManager : MonoBehaviour
{

    #region Instance
    private static GyroManager instance;
    public static GyroManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GyroManager>();
                if (instance == null)
                {
                    instance = new GameObject("Spawned GyroManager", typeof(GyroManager)).GetComponent<GyroManager>();
                }
            }
            return instance;
        }
        set
        {
            instance = value;
        }
    }
    #endregion


    private bool gyroEnabled;
     Gyroscope gyroScope;

    private GameObject cameraContainer;
    private Quaternion rot;


    //private void Start()
    //{
    //    cameracontainer = new gameobject("camera container");
    //    cameracontainer.transform.position = transform.position;
    //    transform.setparent(cameracontainer.transform);

    //    gyroenabled = enabledgyro();

    //}

    public void EnabledGyro()
    {
        if (gyroEnabled)
            return; 
        
        if (SystemInfo.supportsGyroscope)
        {
            gyroScope = Input.gyro;
            gyroScope.enabled = true; 
            gyroEnabled = gyroScope.enabled; 
        }

    }

    private void Update()
    {
        if (gyroEnabled)
        {
            rot = gyroScope.attitude; 
        }
    }
    public Quaternion GetGyroRotation()
    {
        return rot; 
    }
}
