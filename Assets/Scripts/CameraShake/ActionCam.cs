using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionCam : MonoBehaviour
{
    public static void CamShake(float shakeDuration, float power, float decreaseFactor, Transform camTransform, Vector3 originalPos) {
        if (shakeDuration > 0) {
            camTransform.localPosition = originalPos + Random.insideUnitSphere * power;
            shakeDuration -= Time.deltaTime * decreaseFactor;
        } else {
            camTransform.localPosition = originalPos;
            shakeDuration = 0f;
        }
    }
}
