using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;
    public GameObject rightTeleportation;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    //public XRRayInteractor leftRay;
    // XRRayInteractor rightRay;

    // Update is called once per frame
    void Update()
    {
        //bool isleftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftormal, out int leftNumber)
        leftTeleportation.SetActive(leftActivate.action.ReadValue<float>() > 0.1f );
        rightTeleportation.SetActive(rightActivate.action.ReadValue<float>() > 0.1f);

    }
}
