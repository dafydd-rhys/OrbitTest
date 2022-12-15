using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MakePowerup
{

    [MenuItem("Assets/Create/Powerup")]
    public static void Create()
    {
        PowerupUpgrade asset = ScriptableObject.CreateInstance<PowerupUpgrade>();
        AssetDatabase.CreateAsset(asset, "Assets/PowerupShop/NewPowerup.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }

}
