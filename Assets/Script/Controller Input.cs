using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
    public float speed = 5f; // Speed of the player movement
    public Vector2 movement; // Store the movement input
    public AudioSource sfx;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = movement; // Move the player based on the movement input
    }

    public void OnPoint(InputAction.CallbackContext context)
    {
        movement = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>()); // Get the world position of the pointer and calculate the movement vector
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        Debug.Log("Attack!" + context.phase); //phase is the state of the input action (started, performed, canceled)
        if (context.performed == true)
        {
          sfx.Play();
        }
    }
}
