using System;

namespace Plugins
{
    /// <summary>
    /// Attribute from method
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class EditorButtonAttribute : Attribute
    {
        /// <summary>
        /// Button text
        /// </summary>
        public string Name;

        /// <summary>
        /// Should button be enabled in edit mode
        /// </summary>
        public readonly bool ExecuteInEditor;
        /// <summary>
        /// Add Button to Inspector
        /// </summary>
        /// <param name="name">Button text</param>
        /// <param name="executeInEditor">Should button be enabled in edit mode</param>
        
        public EditorButtonAttribute(string name = "", bool executeInEditor = false)
        {
            Name = name;
            ExecuteInEditor = executeInEditor;
        }
    }
}