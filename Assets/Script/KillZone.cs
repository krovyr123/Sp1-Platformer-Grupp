using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    [SerializeField] private Transform spawnPosition;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            other.transform.position = spawnPosition.position;
            other.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}