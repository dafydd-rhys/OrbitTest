using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MakeStage
{
    [MenuItem("Assets/Create/Stage")]
    public static void Create()
    {
        PlanetStage asset = ScriptableObject.CreateInstance<PlanetStage>();
        AssetDatabase.CreateAsset(asset, "Assets/Planets/NewStage.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
}
