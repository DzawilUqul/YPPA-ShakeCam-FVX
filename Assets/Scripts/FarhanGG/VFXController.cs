using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXController : MonoBehaviour
{
    public static void SpawnAndPlayVFX(ParticleSystem vfxPrefab, Transform spawnPoint)
    {
        ParticleSystem vfxInstance = Instantiate(vfxPrefab, spawnPoint.position, Quaternion.identity);

        vfxInstance.Play();

        float delay = 5f;
        Destroy(vfxInstance.gameObject, delay);
    }
}