using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRRenderScale : MonoBehaviour
{
  

    void Start () {
        XRSettings.eyeTextureResolutionScale = 2.5f;
    }

}
