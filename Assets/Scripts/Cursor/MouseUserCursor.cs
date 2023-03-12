using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseUserCursor : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Vector2 cursorHotspot;

    void Start()
    {
        // Hide the default cursor
        Cursor.visible = false;
    }
     void Update()
    {
        transform.position = Input.mousePosition;
    }

    void OnGUI()
    {
        // Draw the custom cursor texture at the current mouse position
        GUI.DrawTexture(new Rect(Event.current.mousePosition.x - cursorHotspot.x, Event.current.mousePosition.y - cursorHotspot.y, cursorTexture.width, cursorTexture.height), cursorTexture);
    }
}