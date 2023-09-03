using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXController : MonoBehaviour
{

    public static void SpawnAndPlayVFX(ParticleSystem vfxPrefab, Transform spawnPoint, float speedMultiplier, float duration, float scaleFactor)
    {
        ParticleSystem vfxInstance = Instantiate(vfxPrefab, spawnPoint.position, Quaternion.identity);

        // Mengubah kecepatan efek visual berdasarkan multiplier
        var mainModule = vfxInstance.main;
        mainModule.simulationSpeed *= speedMultiplier;

        vfxInstance.Play();

        if (duration > 5.0f) //looping jika durasi lebih dari 5 detik
        {
            // Set efek visual untuk melakukan looping jika durasi lebih dari 5 detik
            vfxInstance.loop = true;
        }
        else
        {
            // Jalankan efek visual sekali dan hancurkan setelah durasi yang ditentukan
            vfxInstance.Play();
            Destroy(vfxInstance.gameObject, duration);
        }
        // Mengubah skala efek visual berdasarkan scaleFactor
        vfxInstance.transform.localScale = Vector3.one * scaleFactor;
    }
}
