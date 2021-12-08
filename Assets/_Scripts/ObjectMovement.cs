using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private Vector3 startPos;
    [SerializeField] private float moveDistance = 1f;
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private bool movesX;
    [SerializeField] private bool movesY;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (movesX)
        {
            transform.position = startPos + new Vector3(Mathf.Sin(Time.timeSinceLevelLoad * moveSpeed) * moveDistance, 0.0f, 0.0f);
        }
        else if (movesY)
        {
            transform.position = startPos + new Vector3(0.0f, Mathf.Sin(Time.timeSinceLevelLoad * moveSpeed) * moveDistance, 0.0f);
        }
    }
}
