using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorQueMuda : MonoBehaviour
{
    [SerializeField] private Texture2D hoverCursor;

    private Vector2 customHotspot = new Vector2(2,0);
    private Vector2 defaultHotspot = new Vector2(3, 0);

    private void OnMouseDown()
    {
        Debug.Log("CLiquei");
        Cursor.SetCursor(hoverCursor, customHotspot, CursorMode.Auto);
    }

    private void OnMouseUp()
    {
        Debug.Log("Desquei");
        Cursor.SetCursor(null, defaultHotspot, CursorMode.Auto);
    }

}
