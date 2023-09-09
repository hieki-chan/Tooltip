using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

namespace UnityE.UI
{
    [DisallowMultipleComponent]
    public class Tooltip : MonoBehaviour
    {
        public static Tooltip current;

        public static void Show(string text)
        {
            if (!current)
            {
                throw new NullReferenceException("No tooltip instance found, please create one");
            }
            current.SetTooltip(text);
        }

        public static void Hide()
        {
            if(!current)
            {
                throw new NullReferenceException("No tooltip instance found, please create one");
            }
            current.HideTooltip();
        }

        //Text of the tooltip
        public TextMeshProUGUI m_Text;

        RectTransform m_CanvasRectTransform;
        RectTransform m_RectTransform;
        RectTransform m_TextRectTransform;
        public LayoutElement layoutElement;


        void Awake()
        {
            if (current)
                Debug.LogWarning("There's more than 1 Tooltip");
            current = this;
            m_RectTransform = transform.GetComponent<RectTransform>();
            m_TextRectTransform = m_Text.GetComponent<RectTransform>();
            transform.SetAsLastSibling();
        }

        void Start()
        {
            if(!m_Text)
                m_Text = GetComponentInChildren<TextMeshProUGUI>();
            m_Text.raycastTarget = false;
            if (!layoutElement)
                layoutElement = GetComponentInChildren<LayoutElement>();

            var canvas = GetComponentInParent<Canvas>();
            if (!canvas)
            {
                throw new NullReferenceException("Tooltip should be inside a canvas ");
            }
            m_CanvasRectTransform = canvas.GetComponent<RectTransform>();
            HideTooltip();
        }

        public void SetTooltip(string text)
        {
            //ScreenSpaceOverlay Tooltip
            if (string.IsNullOrEmpty(text))
            {
                return;
            }
            m_Text.text = text;

            layoutElement.enabled = false;
            m_RectTransform.sizeDelta = m_TextRectTransform.sizeDelta + new Vector2(20, 20);
            gameObject.SetActive(true);
        }

        public void HideTooltip()
        {
            m_Text.text = "";
            gameObject.SetActive(false);
        }

        Vector2 mousePos;
        void FixedUpdate()
        {
            mousePos = Input.mousePosition;

            transform.position = new Vector2(mousePos.x, mousePos.y);
            /*if()*/
                m_RectTransform.pivot = new Vector2(mousePos.x / Screen.width, mousePos.y / Screen.height);
            if (m_RectTransform.sizeDelta.x >= m_CanvasRectTransform.sizeDelta.x)
            {
                layoutElement.preferredWidth = m_CanvasRectTransform.sizeDelta.x;
                layoutElement.enabled = true;
            }
            else
            {
                layoutElement.enabled = false;
            }
        }
    }
}