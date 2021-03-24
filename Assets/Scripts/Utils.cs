using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    public static Rect GetScreenRect(Vector3 screenPosition1, Vector3 screenPosition2)
    {
        // Move origin from bottom left to top left
        screenPosition1.y = Screen.height - screenPosition1.y;
        screenPosition2.y = Screen.height - screenPosition2.y;

        // Create Rect
        return new Rect(screenPosition1, screenPosition2 - screenPosition1);

    }
}
