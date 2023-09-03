using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efek : MonoBehaviour
{
    public static void PlayEfek(ParticleSystem vfx)
    {
        vfx.Play();
    }

    public static void StopEfek(ParticleSystem vfx)
    {
        vfx.Stop();
    }
}
