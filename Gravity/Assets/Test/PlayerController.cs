using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector2 move;
    public InputAction inputAction;
    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("Moviiiiing");
        //move = context.ReadValue<Vector2>();
    }
    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }

    void Start()
    {
        
    }

    void Update()
    {
        move = inputAction.ReadValue<Vector2>();
        movePlayer();
    }

    public void movePlayer()
    {
        Vector3 movement = new Vector3(move.x, 0f, move.y);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
