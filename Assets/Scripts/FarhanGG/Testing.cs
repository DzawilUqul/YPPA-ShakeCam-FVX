using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Testing : MonoBehaviour
{
    //public VFXController vFXController;
    public ParticleSystem vfxPrefab; // Reference to the VFX prefab
    public Transform spawnPoint;   // Position to spawn the VFX
    public float speedMultiplier = 1.0f;
    public float duration = 2.0f;
    public float scaleFactor = 1.0f;
    //public bool isLooping;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
            //call the function from the VFXController script
            VFXController.SpawnAndPlayVFX(vfxPrefab, spawnPoint, speedMultiplier, duration, scaleFactor);
        }
    }

    //Floating Text
    /*
    Class EnemyHealth/PlayerHealth
    {
        void TakeDamage()
        {
            ... //Do damage

            if (floatingTextPrefab && currentHealth > 0)
            {
                ShowFloatingText(); 
            }

         ..//isDead
        }

        void ShowFloatingText() //Masukkan codingan ke prefab player/enemy
        {
            var go = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity, transform); //Instantiate the text
            go.GetComponent<TextMesh>().text = currentHealth.ToString(); //Set the text to the current health
        }

     }
     */
}
