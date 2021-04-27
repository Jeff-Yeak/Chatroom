using UnityEngine;

public class OculusInput : VRInputModule
{
    /*
    public OVRInput.Controller m_Source = OVRInput.Controller.RTrackedRemote;
    public OVRInput.Button m_Click = OVRInput.Button.Any;
    */
    public OVRInput.Button clickButton = OVRInput.Button.PrimaryIndexTrigger;

    public OVRInput.Controller controller = OVRInput.Controller.All;
    public override void Process()
    {
        base.Process();
        // Press
        if (OVRInput.GetDown(clickButton, controller))
            Press();
        // Release
        if (OVRInput.GetUp(clickButton, controller))
            Release();

    }
}