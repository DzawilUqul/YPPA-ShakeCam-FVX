using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleInput : MonoBehaviour
{

    [SerializeField] private Camera cam;
    public float shakeDuration;
    public float magnitude;
    public float decreaseFactor;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
           // CinemachineShake.Instance.shakeCamera(3f, 0.25f);
             ShakeCamera.StartCameraShake(shakeDuration,magnitude, decreaseFactor, cam.transform, cam.transform.localPosition);
        }
    }
}
