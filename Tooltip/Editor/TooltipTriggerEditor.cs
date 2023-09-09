using UnityEditor;

namespace UnityE.UI
{
    [CustomEditor(typeof(TooltipTriggerBase), true)]
    internal class TooltipTriggerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            Tooltip tooltip = FindObjectOfType<Tooltip>();
            if ((!tooltip || !tooltip.enabled) && Tooltip.current == null)
                EditorGUILayout.HelpBox("No Tooltip script found." +
                    "Please create one or make sure that the Tooltip is active and enabled.", MessageType.Warning);
            base.OnInspectorGUI();
        }
    }
}