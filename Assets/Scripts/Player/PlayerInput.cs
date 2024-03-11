using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private void Start()
    {
        
    }
    public Vector2 GetTouchDeltaPosition()
    {
        if(Input.touchCount > 0)
            return Input.GetTouch(0).deltaPosition;
        else
            return Vector2.zero;
    }

    public bool IsThereTouchOnScreen()
    {
        if (Input.touchCount > 0) return true;
        else return false;
    }
}
