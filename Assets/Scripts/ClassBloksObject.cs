using System;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class ClassBloksObject
{
    public GameObject GameObject { get; set; }
    public string Name { get; set; }
    public Color Color { get; set; }
    public ClassBloksObject(string name, Color color, GameObject gameObject)
    {
        Name = name;
        Color = color;
        GameObject = gameObject;
    }

}
