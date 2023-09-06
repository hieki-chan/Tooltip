using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace HiekiTools.UI.Tooltip
{
    public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField, TextArea]
        string mDisplayText;


        public void OnPointerEnter(PointerEventData eventData)
        {
            Tooltip.Instance.SetTooltip(mDisplayText);
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            Tooltip.Instance.HideTooltip();
        }

        public void SetTooltip(string aText)
        {
            mDisplayText = aText;
        }
    }
}