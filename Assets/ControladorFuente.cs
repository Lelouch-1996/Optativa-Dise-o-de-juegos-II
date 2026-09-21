using UnityEngine;
using TMPro;

public class ControladorFuente : MonoBehaviour
{
    [Header("Referencia al Texto")]
    public TMP_Text textoObjetivo;

    [Header("Configuración de Tamaño")]
    public float incrementoTamano = 5f;

    // Aumenta el tamaño de la fuente
    public void AumentarTamano()
    {
        if (textoObjetivo != null)
        {
            textoObjetivo.fontSize += incrementoTamano;
        }
    }

    // Disminuye el tamaño de la fuente
    public void DisminuirTamano()
    {
        if (textoObjetivo != null && textoObjetivo.fontSize > incrementoTamano)
        {
            textoObjetivo.fontSize -= incrementoTamano;
        }
    }

    // Cambia el color del texto a Rojo
    public void CambiarColorRojo()
    {
        if (textoObjetivo != null)
        {
            textoObjetivo.color = Color.red;
        }
    }

    // Cambia el color del texto a Blanco por defecto
    public void CambiarColorBlanco()
    {
        if (textoObjetivo != null)
        {
            textoObjetivo.color = Color.white;
        }
    }
}