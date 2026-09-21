using UnityEngine;
using UnityEngine.EventSystems;

public class ElementoArrastrable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 posicionInicial;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();

        // Si no tiene CanvasGroup, se lo agrega automáticamente
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null)
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        posicionInicial = rectTransform.position;
        // Permite que el raycast traspase este elemento mientras se arrastra para detectar qué hay debajo
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Mueve la imagen siguiendo el puntero
        rectTransform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;

        // Si no se soltó sobre un receptor válido, regresa a la posición original
        if (transform.parent == eventData.pointerEnter?.transform || eventData.pointerEnter == null)
        {
            rectTransform.position = posicionInicial;
        }
    }
}