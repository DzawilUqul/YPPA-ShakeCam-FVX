using UnityEngine;

public class VFX : MonoBehaviour
{
    public static void PlayVFX(ParticleSystem particleSystemVFX)
    {
        particleSystemVFX.Play();
    }

    public static void StopVFX(ParticleSystem particleSystemVFX)
    {
        particleSystemVFX.Stop();
    }
}
