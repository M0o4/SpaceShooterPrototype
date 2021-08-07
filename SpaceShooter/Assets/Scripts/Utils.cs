using UnityEngine;

public static class Utils 
{
    public static int BoolToInt(bool val)
    {
        if (val)
            return 1;
        else
            return 0;
    }

    public static bool IntToBool(int val)
    {
        if (val != 0)
            return true;
        else
            return false;
    }

    public static Vector2 GetWorldBoundary()
    {
        return Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }
}
