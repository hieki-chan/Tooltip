using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityE.UI
{
    public class TooltipTriggerUI : TooltipTriggerBase, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField]
        public TriggerType m_TriggerType;

        public enum TriggerType
        {
            Hover,
            [InspectorName("Pressed - Left Pointer")]
            Pressed_0,
            [InspectorName("Pressed - Right Pointer")]
            Pressed_1,
            [InspectorName("Pressed - Middle Pointer")]
            Pressed_2,
            [InspectorName("Pressed - All Pointer")]
            Pressed_3,
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (m_TriggerType == TriggerType.Hover)
                ShowTooltip();
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            HideTooltip();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (HandlePressedTriggerType(eventData))
                ShowTooltip();
        }

        void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
        {
            if (HandlePressedTriggerType(eventData))
                HideTooltip();
        }

        bool HandlePressedTriggerType(PointerEventData eventData)
             => (m_TriggerType == TriggerType.Pressed_0 && eventData.button == PointerEventData.InputButton.Left) ||
                (m_TriggerType == TriggerType.Pressed_1 && eventData.button == PointerEventData.InputButton.Right) ||
                (m_TriggerType == TriggerType.Pressed_2 && eventData.button == PointerEventData.InputButton.Middle) ||
                m_TriggerType == TriggerType.Pressed_3;
    }
}