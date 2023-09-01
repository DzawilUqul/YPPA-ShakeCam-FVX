using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleInput : MonoBehaviour
{

    [SerializeField] private Camera cam;
    public float shakeDuration;
    public float shakeMagnitude;
    public float decreaseFactor;
    private void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            ShakeCamera.StartCameraShake(shakeDuration, shakeMagnitude, decreaseFactor, cam.transform, cam.transform.localPosition);
        }
    }
}
