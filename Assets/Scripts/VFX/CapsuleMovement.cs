using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public Rigidbody rb;
    public ParticleSystem particleSystemVFX;

    void Start()
    {
        
    }

    void Update()
    {
        // Move VFX
        if (Input.GetKey(KeyCode.E))
        {
            rb.velocity = new Vector3(0, 0, 5);

            // Play VFX
            VFX.PlayVFX(particleSystemVFX);
        }

        if (Input.GetKey(KeyCode.R))
        {
            rb.velocity = new Vector3(0, 0, -5);

            // Stop VFX
            VFX.StopVFX(particleSystemVFX);
        }

        // Attack VFX
        if (Input.GetKey(KeyCode.Q))
        {
            
        }

        // Skill VFX
        if (Input.GetKey(KeyCode.X))
        {
            
        }
    }
}
