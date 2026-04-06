using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 movement;
    public bool mouseIsPressed;
    public Vector2 mousePos;
    public UnityEvent<Vector2> OnMouseMoving;
    public UnityEvent OnUsingTool;
    public UnityEvent OnMouseClick;

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
        //Update the movement vector based on the input system
        movement = context.ReadValue<Vector2>();
    }

    public void OnMouseMove(InputAction.CallbackContext context)
    {
        //When the player moves the mouse, update the mouse position and invoke the OnMouseMoving event
        mousePos = context.ReadValue<Vector2>();
        mousePos = Camera.main.ScreenToWorldPoint(mousePos); // Convert screen coordinates to world coordinates
        OnMouseMoving.Invoke(mousePos);
    }

    public void OnMousePress(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            OnMouseClick.Invoke();
           
        }
    }

     public void OnUseTool(InputAction.CallbackContext context)
    {
        //When the player presses the use tool button, set mouseIsPressed to true and invoke the OnUsingTool event
        if (context.started) //https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Actions
        {
            OnUsingTool.Invoke();
            Debug.Log("tool Using");
        }


    }

 
}
