using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private string ENEMY_TAG = "Enemy";
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.tag);
        if (collider.CompareTag(ENEMY_TAG) || collider.CompareTag("Player"))
        {
            Destroy(collider.gameObject);
        }
    }
}
