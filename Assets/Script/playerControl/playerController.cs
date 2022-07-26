using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerControl playerControls;

    public float moveSpeed;

    public Transform orientation;

    Vector3 moveDirection;

    Rigidbody rb;



    private void Awake()
    {
        playerControls = new PlayerControl();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector2 move = playerControls.land.move.ReadValue<Vector2>();
        moveDirection = orientation.forward * move.y + orientation.right*move.x;

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
