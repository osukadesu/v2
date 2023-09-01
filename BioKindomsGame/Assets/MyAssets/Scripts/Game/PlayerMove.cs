using System;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    [SerializeField] float horizontalMove, verticalMove, playerSpeed = 8f;
    [SerializeField] CharacterController player;
    [SerializeField] Vector3 playerInput, camForward, camRight, movePlayer;
    [SerializeField] Camera myCamera;
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        playerInput = new Vector3(horizontalMove, 0, verticalMove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);
        CameraPath();
        movePlayer = playerInput.x * camRight + playerInput.z * camForward;
        player.transform.LookAt(player.transform.position + movePlayer);
        player.Move(movePlayer * playerSpeed * Time.deltaTime);
    }

    void CameraPath()
    {
        camForward = myCamera.transform.forward;
        camRight = myCamera.transform.right;
        camForward.y = 0;
        camRight.y = 0;
        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }
}