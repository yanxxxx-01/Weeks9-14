
using UnityEngine;
using UnityEngine.InputSystem;

public class TwinMovement : MonoBehaviour
{
    public Vector2 movement; // Store the movement input
    public Vector2 rotation; // Store the rotation input
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movement * Time.deltaTime * 5; // Move the player based on the movement input
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        rotation = context.ReadValue<Vector2>();
    }
}
