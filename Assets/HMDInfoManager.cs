using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Is Device Active" + XRSettings.isDeviceActive);
        // Debug.Log("Device Name is : " + XRSettings.loadedDeviceName);

        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No Headset Plugged");

        }
        else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HDM"
        || XRSettings.loadedDeviceName == "MockHDMDisplay"))
        {
            Debug.Log("Using Mock HDM");

        }
        else
        {
            Debug.Log("We have a headset " + XRSettings.loadedDeviceName);

        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
