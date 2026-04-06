using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class WhenMouseOn : MonoBehaviour
{
    public SpriteRenderer sr;
    private Vector2 mousePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void MouseOn(Vector2 mousePos)
    {
        //When the mouse enters the sprite's area, change its color to red
        if (sr.bounds.Contains(mousePos))
        {
            sr.color = Color.gray; // Change color to red when mouse is on the sprite
        }
        else
        {
            sr.color = Color.white; // Change color back to white when mouse is not on the sprite
        }
    }
}
