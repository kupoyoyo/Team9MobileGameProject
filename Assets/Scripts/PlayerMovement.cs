using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Joystick joystick;

    [SerializeField] private CharacterController controller;
    [SerializeField] private GameObject mainCamera;

    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float fallSpeed = 3f;
    [SerializeField] private float playerOffset = 19f;

    //[SerializeField] private float moveX = 0f;
    //[SerializeField] private float moveY = 0f;

    void Update()
    {

        Vector3 move = new Vector3(joystick.Horizontal * moveSpeed, joystick.Vertical * moveSpeed, fallSpeed);

        controller.Move(move * Time.deltaTime * moveSpeed);

        Vector3 cameraPos = new Vector3(0, 0, controller.transform.position.z - playerOffset);

        mainCamera.transform.position = cameraPos;
    }
}
