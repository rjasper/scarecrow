using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MovementPlayer))]
public class MovementPlayerEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        MovementPlayer movementPlayer = (MovementPlayer)target;

        movementPlayer.minimumInput = EditorGUILayout.FloatField("Minimum Input", movementPlayer.minimumInput);
    }

}
