using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ButtonObject
{
    public int id;
    public string word;
    public string pic;
    public string audio;
    public string synonym;
    public string definition;
    public string example;
    public string PositionXYZ;
    public string RotationXYZ;
    public int scene;
}


[Serializable]
public class WordObject
{
    public int id;
    public string pic;
    public string audio;
    public string synonym;
    public string definition;
    public string example;
    public string position;
    public string rotation;
    public int scene;
}


[Serializable]
public class SceneData
{
    public string scene_id;
    public string scene_name;
    public string scene_image;
    public string level;
}

[Serializable]
public class SceneList
{
    public SceneData[] Scenes;
}

[Serializable]
public class InitializeButton
{
    public int id { get; set; }
    public string word { get; set; }
    public string pic { get; set; }
    public string audio { get; set; }
    public string synonym { get; set; }
    public string definition { get; set; }
    public string example { get; set; }
    public string position { get; set; }
    public string rotation { get; set; }
    public int scene { get; set; }
}

[Serializable]
public class AllWordObect
{
    public int id { get; set; }
    public string word { get; set; }
    public string pic { get; set; }
    public string audio { get; set; }
    public string synonym { get; set; }
    public string definition { get; set; }
    public string example { get; set; }
    public string position { get; set; }
    public string rotation { get; set; }
    public int scene { get; set; }
}

[Serializable]
public class ImageClass
{
    public int id { get; set; }
    public List<int> words { get; set; }
    public string scene_name { get; set; }
    public string scene_image { get; set; }
    public int level { get; set; }
}

