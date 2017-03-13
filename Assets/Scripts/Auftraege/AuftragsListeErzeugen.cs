using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AuftragsListeErzeugen {
    [MenuItem("Assets/Create/Auftrags Liste")]

    public static AuftragsClassList Create()
    {
        AuftragsClassList asset = ScriptableObject.CreateInstance<AuftragsClassList>();
        AssetDatabase.CreateAsset(asset, "Assets/Lists/AuftraegeList.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }

	
}
