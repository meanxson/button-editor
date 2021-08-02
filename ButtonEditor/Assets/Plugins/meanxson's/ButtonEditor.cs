using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Plugins
{
    [CustomEditor(typeof(Object), true, isFallback = false)]
    [CanEditMultipleObjects]
    public class ButtonEditor : Editor
    {
    public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            foreach (var t in targets)
            {
                var methodInfos = t.GetType().GetMethods().Where(m => m.GetCustomAttributes()
                    .Any(a => a.GetType() == typeof(EditorButtonAttribute)));

                foreach (var mi in methodInfos)
                {
                    {
                        var attribute = (EditorButtonAttribute) mi.GetCustomAttribute(typeof(EditorButtonAttribute));
                        var disable = !attribute.ExecuteInEditor && !Application.isPlaying; 
                        EditorGUI.BeginDisabledGroup(disable);
                        
                        if (GUILayout.Button(attribute.Name))
                        {
                            attribute.Name = string.IsNullOrEmpty(attribute.Name) ? nameof(mi) : attribute.Name; 
                            mi.Invoke(t, null);
                        }
                        
                        EditorGUI.EndDisabledGroup();
                    }
                }
            }
        }
    }
}