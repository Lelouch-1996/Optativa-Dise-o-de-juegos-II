using UnityEngine;
using UnityEngine.UI;

public class AnimacionBucle : MonoBehaviour
{
    [Header("Configuración de Sprites")]
    public Image imagenObjetivo;        // Componente Image UI donde se muestra el sprite
    public Sprite[] fotogramas = new Sprite[8]; // Array para colocar los 8 sprites

    [Header("Ajustes de Bucle")]
    public float velocidadAnimacion = 0.1f; // Tiempo en segundos por fotograma
    private int indiceFotogramaActual = 0;
    private float temporizador = 0f;

    // BUCLE PRINCIPAL (Game Loop de Unity)
    void Update()
    {
        // Si no se asignaron los 8 sprites o la imagen, no ejecutamos nada
        if (imagenObjetivo == null || fotogramas.Length == 0) return;

        // Acumulamos el tiempo transcurrido desde el último fotograma
        temporizador += Time.deltaTime;

        // Comprobamos si es momento de avanzar de fotograma
        if (temporizador >= velocidadAnimacion)
        {
            temporizador = 0f;

            // Avanzamos al siguiente fotograma en bucle (0 a 7 y regresa a 0)
            indiceFotogramaActual = (indiceFotogramaActual + 1) % fotogramas.Length;

            // Actualizamos la imagen en la interfaz
            imagenObjetivo.sprite = fotogramas[indiceFotogramaActual];
        }
    }
}