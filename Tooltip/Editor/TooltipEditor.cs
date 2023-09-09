using UnityEditor;

namespace UnityE.UI
{
    [CustomEditor(typeof(Tooltip))]
    internal class TooltipEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            Tooltip tooltip = (Tooltip)target;
            if ((!tooltip.gameObject.activeInHierarchy || !tooltip.enabled) && Tooltip.current == null)
                EditorGUILayout.HelpBox("Ensure that the tooltip is active or enabled to create " +
                    "a singleton instance in the Awake() method.",
                    MessageType.Warning);
            base.OnInspectorGUI();
        }
    }
}