using UnityEngine;
using UnityEngine.EventSystems;

public class DragSpriteUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();

        // Agrega CanvasGroup si no existe para controlar la transparencia durante el arrastre
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Reduce ligeramente la opacidad al arrastrar para retroalimentación visual
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Actualiza la posición siguiendo el cursor en el Canvas
        rectTransform.anchoredPosition += eventData.delta / GetCanvasScale();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Restaura la opacidad al soltar
        canvasGroup.alpha = 1.0f;
        canvasGroup.blocksRaycasts = true;
    }

    private float GetCanvasScale()
    {
        Canvas canvas = GetComponentInParent<Canvas>();
        return canvas != null ? canvas.scaleFactor : 1.0f;
    }
}