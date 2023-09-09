namespace UnityE.UI
{
    public class TooltipTrigger : TooltipTriggerBase
    {
        private void OnMouseEnter()
        {
            ShowTooltip();
        }

        public void OnMouseExit()
        {
            HideTooltip();
        }
    }
}