using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
        }
    }
}
