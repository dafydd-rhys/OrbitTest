using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class RocketUpgrade : ScriptableObject
{
    public string upgradeName = "Upgrade Name Here";
    public int cost = 50;
    public string description;

    public int speed = 5;
    public float delay = 0.5f;
    public float accuracy = 0.7f;
    public Sprite image;
}
