using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Tools : MonoBehaviour
{
    public int toolID; // 0 for Shovel, 1 for jug, 3 for manure 
    public SpriteRenderer shovel; 
    public SpriteRenderer jug;
    public SpriteRenderer manure;

    public UnityEvent OnSelectTool;

    Vector2 mousePos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //check if the mouse is on the shovel, jug, or manure sprite and select the corresponding tool
        if (shovel.bounds.Contains(mousePos) && Mouse.current.leftButton.wasPressedThisFrame)
        {
            toolID = 0;
            Debug.Log("Shovel selected");
        }
        else if (jug.bounds.Contains(mousePos) && Mouse.current.leftButton.wasPressedThisFrame)
        {
            toolID = 1;
            Debug.Log("jug selected");
        }
        else if (manure.bounds.Contains(mousePos)&& Mouse.current.leftButton.wasPressedThisFrame)
        {
            toolID = 2;
            Debug.Log("manure selected");
        }
    }

  
}
