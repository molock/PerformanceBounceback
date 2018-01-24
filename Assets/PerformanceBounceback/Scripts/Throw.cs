﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device device;
    private Rigidbody ballRigidBody;
    public float throwForce = 2f;

    // Use this for initialization
    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        device = SteamVR_Controller.Input((int)trackedObj.index);
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
            {

                //Multi Throwing
                col.transform.SetParent(null);
                ballRigidBody = col.GetComponent<Rigidbody>();
                ballRigidBody.isKinematic = false;

                ballRigidBody.velocity = device.velocity * throwForce;
                ballRigidBody.angularVelocity = device.angularVelocity;
            }
            else if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                col.GetComponent<Rigidbody>().isKinematic = true;
                col.transform.SetParent(gameObject.transform);

                device.TriggerHapticPulse(2000);
            }
        }
    }
}
