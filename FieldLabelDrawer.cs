using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR

[CustomPropertyDrawer(typeof(FieldLabelAttribute))]
internal sealed class FieldLabelDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        FieldLabelAttribute fLabel = (FieldLabelAttribute) attribute;
        EditorGUI.PropertyField(position, property, new GUIContent(fLabel.text));
    }
}
#endif