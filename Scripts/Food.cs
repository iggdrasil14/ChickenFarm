using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chiken"))
        {
            Debug.Log("Chicken collided with food. Destroying food.");
            Destroy(gameObject);
        }
    }
}

