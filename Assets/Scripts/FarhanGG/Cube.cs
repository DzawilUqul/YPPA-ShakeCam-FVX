using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Rigidbody mlaku;
    public ParticleSystem vfx;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Floor")
        {
            Debug.Log("as");
            Efek.PlayEfek(vfx);
            //Destroy(vfx.gameObject);

        }
    }
    void Start()
    {

    }

    void Update()
    {
        //kondisi kapan vfx jalan, berhenti, ilang
        
        //Attack
        if (Input.GetKeyDown(KeyCode.B))
        {
            //mlaku.velocity = new Vector3(0,0,5);
            Efek.PlayEfek(vfx);
        }
    }
}
