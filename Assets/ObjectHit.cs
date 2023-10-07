using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Bumped into a wall");
        GetComponent<MeshRenderer>().material.color = Color.magenta;
    }
}
