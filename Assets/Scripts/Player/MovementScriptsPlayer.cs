using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScriptsPlayer : MonoBehaviour
{
    public PlayerClass playerClass;
    public float moveSpeed;
    public Rigidbody2D rb;
    Vector2 moveDirection = Vector2.zero;


    public RICOCHETDUNGEON playerInput;

    public InputAction move;
    public InputAction fire;

    private void Start()
    {
        moveSpeed = playerClass.moveSpeed;
    }

    private void Awake()
    {
        playerInput = new RICOCHETDUNGEON();
    }

    private void OnEnable()
    {
        move = playerInput.Player.Move;
        move.Enable();

    }


    private void OnDisable()
    {
        move.Disable();
    }


    // Update is called once per frame
    private void Update()
    {
        moveDirection = move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }


}
