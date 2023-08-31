using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXController : MonoBehaviour
{
    public ParticleSystem vfxPrefab; // Reference to the VFX prefab
    public Transform spawnPoint;   // Position to spawn the VFX
    private ParticleSystem vfxInstance; // Reference to the spawned VFX instance

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnAndPlayVFX();
        }
    }

    void SpawnAndPlayVFX()
    {
        // Spawn the VFX prefab at the spawnPoint position
        vfxInstance = Instantiate(vfxPrefab, spawnPoint.position, Quaternion.identity);

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