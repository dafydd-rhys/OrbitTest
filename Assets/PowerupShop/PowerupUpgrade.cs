using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PowerupUpgrade : ScriptableObject
{
    public string upgradeName = "Upgrade Name Here";    //name of the upgrade
    public int[] cost = { 0, 0, 0 };   //cost of the upgrade

    public string description;  //description of the upgrade
    public PowerupType type;


    public Sprite image;    //icon for the upgrade

    public enum PowerupType
    {
        Passive,
        Active
    }
}