using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public float gravityScale = 5f;

    private Vector3 moveDirection;

    public CharacterController charController;

    private Camera theCamera;

    // Start is called before the first frame update
    void Start()
    {
        theCamera = Camera.current;
    }

    // Update is called once per frame
    void Update()
    {
        float yStore = moveDirection.y;
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveDirection = moveDirection * moveSpeed;
        moveDirection.y = yStore;

        if (Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpForce;
        }

        moveDirection.y += Physics.gravity.y * Time.deltaTime * gravityScale;

        //transform.position = transform.position + (moveDirection * Time.deltaTime * moveSpeed);

        charController.Move(moveDirection * Time.deltaTime);

        transform.rotation = Quaternion.Euler(0f, theCamera.transform.rotation.eulerAngles.y, 0f);
    }
}
