using System;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    [SerializeField] float jumpForce = 5, fallVelY, horizontalMove, verticalMove, playerSpeed = 8f, gravity = 9.8f;
    [SerializeField] CharacterController player;
    [SerializeField] Vector3 playerInput, camForward, camRight, movePlayer;
    [SerializeField] Camera myCamera;
    [SerializeField] Animator myAnim;

    void Start()
    {
        myAnim.SetBool("idle", true);
        myAnim.SetBool("run", false);
    }
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        playerInput = new Vector3(horizontalMove, 0, verticalMove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);
        CameraPath();
        movePlayer = playerInput.x * camRight + playerInput.z * camForward;
        movePlayer *= playerSpeed;
        player.transform.LookAt(player.transform.position + movePlayer);
        SetGravity();
        PlayerSkills();
        player.Move(movePlayer * Time.deltaTime);
        if (horizontalMove != 0.0f || verticalMove != 0.0f)
        {
            myAnim.SetBool("idle", false);
            myAnim.SetBool("run", true);
        }
        else
        {
            myAnim.SetBool("idle", true);
            myAnim.SetBool("run", false);
        }
    }
    void PlayerSkills()
    {
        if (player.isGrounded && Input.GetButtonDown("Jump"))
        {
            fallVelY = jumpForce;
            movePlayer.y = fallVelY;
        }
    }
    void SetGravity()
    {
        if (player.isGrounded)
        {
            fallVelY = -gravity * Time.deltaTime;
            movePlayer.y = fallVelY;
        }
        else
        {
            fallVelY -= gravity * Time.deltaTime;
            movePlayer.y = fallVelY;
        }
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