using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
    public void StartCameraShake(float duration, float magnitude, float decreaseFactor, Transform camTransform, Vector3 camOriginalPos)
    {
        StartCoroutine(Shake(duration, magnitude, decreaseFactor, camTransform, camOriginalPos));
    }

    IEnumerator Shake(float duration, float magnitude, float decreaseFactor, Transform camTransform, Vector3 camOriginalPos)
    {
        //float elapsed = 0.0f;
        while (duration > 0)
        {
            Vector3 newPos = camOriginalPos + Random.insideUnitSphere * magnitude;
            camTransform.localPosition = newPos;
            duration -= Time.deltaTime;

            yield return null;
        }
        camTransform.localPosition = camOriginalPos;
    }
}
