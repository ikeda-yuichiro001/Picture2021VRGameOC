using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AutoGetCompornennt))]//拡張するクラスを指定
public class AutoGetCompornennt : Editor
{
    public override void OnInspectorGUI()
    {
        //元のInspector部分を表示
        base.OnInspectorGUI();

        //ボタンを表示
        if (GUILayout.Button("Button"))
        {
            Debug.Log("押した!");
        }
    }
}
