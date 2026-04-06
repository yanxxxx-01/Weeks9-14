using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Tools : MonoBehaviour
{
    public int toolID; // 0 for Shovel, 1 for jug, 3 for manure 

    public SpriteRenderer shovel; 
    public SpriteRenderer jug;
    public SpriteRenderer manure;

    public bool mouseOnShovel;
    public bool mouseOnJug;
    public bool mouseOnManure;

    private bool isMouseOnToolsLastFrame = false;
    private bool isMouseOnTools = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
    }

    public void OnMouseMove(Vector2 mousePos)
    {
        //Update the mouse position when the player moves the mouse
        //Check if the mouse is on any of the tool sprites and update the isMouseOnTools variable accordingly
        mouseOnShovel = (shovel.bounds.Contains(mousePos));

        mouseOnJug = (jug.bounds.Contains(mousePos));

        mouseOnManure = (manure.bounds.Contains(mousePos));

    }
    public void OnMouseClick()
    {  
        //check if the mouse is on the shovel, jug, or manure sprite and select the corresponding tool
        if (mouseOnShovel == true)
        {
            //If the mouse is on the shovel sprite, set toolID to 0 and log "Shovel selected"
            toolID = 0;
            Debug.Log("Shovel selected");

        }
        else if (mouseOnJug == true)
        {
            toolID = 1;
            Debug.Log("jug selected");
        }
        else if (mouseOnManure == true)
        {
            toolID = 2;
            Debug.Log("manure selected");
        }

    }
 
}
