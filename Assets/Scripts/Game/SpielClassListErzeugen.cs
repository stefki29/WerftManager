using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpielClassListErzeugen {
    [MenuItem("Assets/Create/Spiel Liste")]
    
    public static SpielClassList Create()
    {
        SpielClassList asset = ScriptableObject.CreateInstance<SpielClassList>();
        AssetDatabase.CreateAsset(asset, "Assets/Lists/SpielList.asset");
        AssetDatabase.SaveAssets();
        return asset;

    }
}
