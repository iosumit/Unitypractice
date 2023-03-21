using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    Vector3 tempPos;
    [SerializeField]
    private float minX = -13.5f, maxX = 69.2f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
            return;
        tempPos = transform.position;
        if (player.position.x > minX && player.position.x < maxX)
        {
            tempPos.x = player.position.x;
            transform.position = tempPos;
        }
    }
}
