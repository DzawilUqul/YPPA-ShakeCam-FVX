using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
     private static ShakeCamera instance;

    private void Awake() {
        instance = this;
    }
    public static void StartCameraShake(float duration, float magnitude, float decreaseFactor, Transform camTransform, Vector3 camOriginalPos)
    {
        instance.StartCoroutine(instance.Shake(duration, magnitude, decreaseFactor, camTransform, camOriginalPos));
    }

    private IEnumerator Shake(float duration, float magnitude, float decreaseFactor, Transform camTransform, Vector3 camOriginalPos)
    {
        //float elapsed = 0.0f;
        while (duration > 0)
        {
            Vector3 newPos = camOriginalPos + Random.insideUnitSphere * magnitude;
            camTransform.localPosition = newPos;
            duration -= Time.deltaTime * decreaseFactor;

            yield return null;
        }
        camTransform.localPosition = camOriginalPos;
    }
}
