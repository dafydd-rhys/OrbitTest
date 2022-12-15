using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MakeRocketUpgrade
{

    [MenuItem("Assets/Create/Rocket Upgrade")]
    public static void Create()
    {
        RocketUpgrade asset = ScriptableObject.CreateInstance<RocketUpgrade>();
        AssetDatabase.CreateAsset(asset, "Assets/RocketShop/NewRocketUpgrade.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }

}
