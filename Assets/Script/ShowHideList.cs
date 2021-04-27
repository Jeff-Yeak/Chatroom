using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ShowHideList : ScriptableObject
{
    public bool isWordSelected = false;
    public string ShowHideStatus = "Show";

    public void HideList()
    {
        if (ShowHideStatus == "Show")
        {
            ShowHideStatus = "Hide";
        }
    }

    public void ShowList()
    {
        if(ShowHideStatus == "Hide")
        {
            ShowHideStatus = "Show";
        }
    }
}
