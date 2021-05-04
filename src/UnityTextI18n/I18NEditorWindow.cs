using System;
using UnityEditor;

namespace UnityTextI18n
{
    public class I18NEditorWindow : EditorWindow
    {
        [MenuItem("I18N/Editor")]
        private static void Init()
        {
            var editorWindow = GetWindow(typeof(I18NEditorWindow));
            editorWindow.Show();
        }

        private void OnGUI()
        {
            throw new NotImplementedException("Tepache Labs is working on this...");
        }
    }
}
