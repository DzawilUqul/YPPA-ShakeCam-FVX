using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    // Transform of the camera to shake. Grabs the gameObject's transform
    
    public Transform camTransform;

    // How long the object should shake for.
    public float duration;

    // Amplitude of the shake. A larger value shakes the camera harder.
    public float magnitude;
    public float decreaseFactor;

    Vector3 originalPos;

    public ShakeCamera shakeCamera;

    // if null.
    void Awake() {
        if (camTransform == null) {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }


    void OnEnable() {
        originalPos = camTransform.localPosition;
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.Space)) {
            ShakeCamera.StartCameraShake(duration, magnitude, decreaseFactor, camTransform, originalPos);
        }

    }
}
