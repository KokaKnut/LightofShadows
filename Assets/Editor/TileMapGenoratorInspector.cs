﻿using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(TileMapGenerator))]
public class TileMapGenoratorInspector : Editor {

	public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Regenerate"))
        {
            ((TileMapGenerator)target).BuildTileMap();
        }
    }
}