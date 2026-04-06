using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 movement;
    public bool isUsingTool = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the player based on the movement vector and speed
        transform.position += (Vector3)movement * Time.deltaTime * speed;
    }

    //When the player presses the movement keys, update the movement vector
    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnUseTool(InputAction.CallbackContext context)
    {
        isUsingTool = context.ReadValueAsButton();
        Debug.Log(isUsingTool);
    }
}
