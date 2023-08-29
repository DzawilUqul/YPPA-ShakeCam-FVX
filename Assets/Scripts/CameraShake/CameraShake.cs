using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Transform of the camera to shake. Grabs the gameObject's transform
    
    public Transform camTransform;

    // How long the object should shake for.
    public float shakeDuration;

    // Amplitude of the shake. A larger value shakes the camera harder.
    public float power;
    public float decreaseFactor;

    Vector3 originalPos;

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

        if (Input.GetKey(KeyCode.Space)) {
            ActionCam.CamShake(shakeDuration, power, decreaseFactor, camTransform, originalPos);
        }

    }
}
