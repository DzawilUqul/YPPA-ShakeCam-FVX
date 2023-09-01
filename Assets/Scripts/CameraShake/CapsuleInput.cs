using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleInput : MonoBehaviour
{
    [SerializeField] private ShakeCamera shakeCamera;
    [SerializeField] private Camera cam;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CinemachineShake.Instance.shakeCamera(3f, 0.25f);
            // shakeCamera.StartCameraShake(1, 0.05f, 1, cam.transform, cam.transform.localPosition);
        }
    }
}
