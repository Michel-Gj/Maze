using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterBehaviour : MonoBehaviour
{
    public GameObject spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            CharacterController temp = other.gameObject.GetComponent<CharacterController>();
            temp.enabled = false;
            other.gameObject.transform.position = spawnPoint.transform.position;
            temp.enabled = true;
            
            Debug.Log("Teleport Triggered");
        }
        Debug.Log("Teleport Triggered 2");
    }
}
