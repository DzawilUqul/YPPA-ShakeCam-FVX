using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXController : MonoBehaviour
{
    public static VFXController instance;
    void Awake()
    {
        instance = this;
    }

    public void SpawnAndPlayVFX(ParticleSystem vfxPrefab, Transform spawnPoint)
    {
        // Reference to the spawned VFX instance
        ParticleSystem vfxInstance = Instantiate(vfxPrefab, spawnPoint.position, Quaternion.identity); // Spawn the VFX prefab at the spawnPoint position

        // Play the spawned VFX
        vfxInstance.Play();

        // Call a method to destroy the VFX after a certain duration
        StartCoroutine(DestroyVFXAfterDelay(vfxInstance, vfxInstance.duration));
    }

    IEnumerator DestroyVFXAfterDelay(ParticleSystem vfx, float delay)
    {
        yield return new WaitForSeconds(delay);

        // Stop and destroy the VFX instance
        vfx.Stop();
        Destroy(vfx.gameObject);
    }
}