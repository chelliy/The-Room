using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerControl playerControls;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = playerControls.land.move.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(move.x, 0, move.y);
        this.transform.position += (moveDirection*Time.deltaTime);
        Debug.Log(move);
    }
}
