using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Testing : MonoBehaviour
{
    //public VFXController vFXController;
    public ParticleSystem vfxPrefab; // Reference to the VFX prefab
    public Transform spawnPoint;   // Position to spawn the VFX

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
            //call the function from the VFXController script
            VFXController.SpawnAndPlayVFX(vfxPrefab, spawnPoint);
        }
    }
}
