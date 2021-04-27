using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SameSizeScroll : MonoBehaviour
{
    public Scrollbar OriginalScrollbar, NewScrollBar;
    public bool up = false;
    public bool down = false;
    public OVRInput.Controller controller = OVRInput.Controller.All;
    public OVRInput.Axis2D touchPAD = OVRInput.Axis2D.PrimaryTouchpad;
    public float TouchScrollSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Update()
    {
        if (OVRInput.Get(touchPAD, controller) == Vector2.zero)
        {
            NoTouch();
        }
        else if (OVRInput.Get(touchPAD, controller).y > Vector2.zero.y)
        {
            TouchUp();
        }
        else if (OVRInput.Get(touchPAD, controller).y < Vector2.zero.y)
        {
            TouchDown();
        }
    }

    // Update is called once per frame
    public void Clicked()
    {
        OriginalScrollbar.value = NewScrollBar.value;
    }
    public void NoTouch()
    {
        down = false;
        up = false;
    }
    public void TouchUp()
    {
        down = false;
        up = true;
    }
    public void TouchDown()
    {
        up = false;
        down = true;
    }
    private void LateUpdate()
    {
        if (up == true)
        {
            NewScrollBar.value += TouchScrollSpeed;
        }
        if (down == true)
        {
            NewScrollBar.value -= TouchScrollSpeed;
        }
    }
}
