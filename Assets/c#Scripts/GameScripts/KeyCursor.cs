using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCursor : MonoBehaviour
{
    public Texture2D cursorCustom;

    public void Start()
    {
        Cursor.SetCursor(cursorCustom, Vector2.zero, CursorMode.Auto);
    }
}

