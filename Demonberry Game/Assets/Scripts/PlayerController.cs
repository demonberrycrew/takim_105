using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera theCamera;
    public float Speed = 2f;
    public float SprintSpeed = 5f;
    public float rotationSpeed = 15f;
    public float AnimationBlendSpeed = 5f;
    public float JumpSpeed = 6;
    CharacterController CharController;
    Animator PlayerAnimator;

    float mDesireRotation = 0f;
    float mDesireAnimSpeed = 0f;
    bool mSprinting = false;

    float mSpeedY = 0;
    float mGravity = -9.81f;

    bool mJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        CharController = GetComponent<CharacterController>();
        PlayerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        if(Input.GetButtonDown("Jump") && !mJumping)
        {
            mJumping = true;
            PlayerAnimator.SetTrigger("Jump");

            mSpeedY += JumpSpeed;
        }

        if (!CharController.isGrounded)
        {
            mSpeedY += mGravity * Time.deltaTime;
        }
        else if(mSpeedY < 0)
        {
            mSpeedY = 0;
        }

        PlayerAnimator.SetFloat("SpeedY", mSpeedY / JumpSpeed);

        if(mJumping && mSpeedY < 0)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, .1f, LayerMask.GetMask("Default")))
            {
                mJumping = false;
                PlayerAnimator.SetTrigger("Land");
            }
        }
   
        mSprinting = Input.GetKey(KeyCode.LeftShift);

        Vector3 movement = new Vector3(x, 0, z).normalized;

        Vector3 rotatedMovement = Quaternion.Euler(0, theCamera.transform.rotation.eulerAngles.y, 0) * movement;
        Vector3 verticalMovement = Vector3.up * mSpeedY;

        CharController.Move((verticalMovement + (rotatedMovement * (mSprinting ? SprintSpeed : Speed))) * Time.deltaTime);

        if(rotatedMovement.magnitude > 0)
        {
            mDesireRotation = Mathf.Atan2(rotatedMovement.x, rotatedMovement.z) * Mathf.Rad2Deg;
            mDesireAnimSpeed = mSprinting ? 1 : .5f;
        }
        else
        {
            mDesireAnimSpeed = 0;
        }

        PlayerAnimator.SetFloat("Speed", Mathf.Lerp(PlayerAnimator.GetFloat("Speed"), mDesireAnimSpeed, AnimationBlendSpeed * Time.deltaTime));
        Quaternion currentRotation = transform.rotation;
        Quaternion targetRotation = Quaternion.Euler(0, mDesireRotation, 0);
        transform.rotation = Quaternion.Lerp(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
