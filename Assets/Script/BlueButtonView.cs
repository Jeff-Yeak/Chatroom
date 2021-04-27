using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButtonView : MonoBehaviour
{

    public void InstantBlueButton(AllWordObect item ,GameObject Button, Vector3 pos, Quaternion rot, Transform parent)
    {
        var GO = Instantiate(Button, pos, rot, parent);
        GO.name = item.word;
    }
    
    public void ShowBlueButt(GameObject ButtonPrefab, Vector3 DotPosition, Quaternion DotRotation, Transform parent)
    {
        Instantiate(ButtonPrefab, new Vector3(DotPosition.x, DotPosition.y, DotPosition.z + 0.2f), DotRotation, parent);
    }
}
