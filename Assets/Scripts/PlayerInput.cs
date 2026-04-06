using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 movement;
    public UnityEvent OnUsingTool;

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
        if (context.started) //https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Actions
        { 
            OnUsingTool.Invoke();
            Debug.Log("tool Using");
        }
        
    }
}
