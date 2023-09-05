using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public float destroyTime = 3f;
    public Vector3 offside = new Vector3(0, 2, 0);
    void Start()
    {
        Destroy(gameObject, destroyTime); //Destroy the text after 3 seconds
        transform.localPosition += offside; //Make the text appear above the enemy
    }
}
