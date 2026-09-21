using UnityEngine;
using UnityEngine.EventSystems;

public class ZonaReceptora : MonoBehaviour, IDropHandler
{
    // Se activa en el instante que sueltas un elemento arrastrable sobre este objeto
    public void OnDrop(PointerEventData eventData)
    {
        GameObject objetoSoltado = eventData.pointerDrag;

        if (objetoSoltado != null)
        {
            Debug.Log("¡Colisión/Interacción detectada! Se soltó: " + objetoSoltado.name + " sobre " + gameObject.name);

            // Ejemplo de acción: Centrar el objeto arrastrado sobre esta zona
            objetoSoltado.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
        }
    }
}