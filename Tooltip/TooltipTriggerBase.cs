using System.Collections;
using UnityEngine;

namespace UnityE.UI
{
    [DisallowMultipleComponent]
    public class TooltipTriggerBase : MonoBehaviour
    {
        [SerializeField, TextArea]
        protected string m_DisplayText;
        public float delayedCall = .1733f;

        public void ShowTooltip() => StartCoroutine(ShowTooltipDelayed());
        public void HideTooltip()  
        {
            StopCoroutine(ShowTooltipDelayed());
            Tooltip.Hide();
        }
        public void SetTooltip(string aText)
        {
            m_DisplayText = aText;
        }
        IEnumerator ShowTooltipDelayed()
        {
            yield return new WaitForSeconds(delayedCall);
            Tooltip.Show(m_DisplayText);
        }
    }
}