using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Joystick joystick;

    [SerializeField] private CharacterController controller;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject fogPlane;
    [SerializeField] private GameObject edgePlane;

    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float fallSpeed = 3f;
    [SerializeField] private float cameraOffset = 19f;
    [SerializeField] private float fogPlaneOffset = 80f;
    [SerializeField] private float edgePlaneOffset = 895f;

    //[SerializeField] private float moveX = 0f;
    //[SerializeField] private float moveY = 0f;

    void Update()
    {

        Vector3 move = new Vector3(joystick.Horizontal * moveSpeed, joystick.Vertical * moveSpeed, fallSpeed);

        controller.Move(move * Time.deltaTime * moveSpeed);

        Vector3 cameraPos = new Vector3(0, 0, controller.transform.position.z - cameraOffset);
        Vector3 fogPos = new Vector3(0, 0, controller.transform.position.z + fogPlaneOffset);
        Vector3 edgePos = new Vector3(0, 0, controller.transform.position.z + edgePlaneOffset);

        mainCamera.transform.position = cameraPos;
        fogPlane.transform.position = fogPos;
        edgePlane.transform.position = edgePos;
    }
}
