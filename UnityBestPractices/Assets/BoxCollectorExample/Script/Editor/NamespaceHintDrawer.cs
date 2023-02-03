#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;

namespace Main.Editor.NameSpaceDrawer
{
#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(NamespaceHint))]
#endif
    public class NamespaceHintDrawer
#if UNITY_EDITOR
        : PropertyDrawer
#endif
    {
#if UNITY_EDITOR

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var t = property.serializedObject.targetObject.GetType();
            EditorGUI.LabelField(position, t.FullName);
        }

#endif
    }


    [System.Serializable]
    public struct NamespaceHint
    {
    }
}