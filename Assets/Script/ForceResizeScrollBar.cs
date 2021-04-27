using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceResizeScrollBar : ScrollRect
{
    public bool up = false;
    public bool down = false;
    public float TouchScrollSpeed = 0.017f;
    public OVRInput.Controller controller = OVRInput.Controller.All;
    public OVRInput.Axis2D touchPAD = OVRInput.Axis2D.PrimaryTouchpad;
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
    override protected void LateUpdate()
    {
        base.LateUpdate();
        if (this.verticalScrollbar)
        {
            this.verticalScrollbar.size = 0.02f;
        }
        if (up == true)
        {
            this.verticalScrollbar.value += TouchScrollSpeed;
        }
        if (down == true)
        {
            this.verticalScrollbar.value -= TouchScrollSpeed;
        }
    }

    override public void Rebuild(CanvasUpdate executing)
    {
        base.Rebuild(executing);
        if (this.verticalScrollbar)
        {
            this.verticalScrollbar.size = 0.02f;
        }
    }
}
