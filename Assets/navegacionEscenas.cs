using UnityEngine;
using UnityEngine.SceneManagement;

public class NavegacionEscenas : MonoBehaviour
{
    // Cambia a otra escena especificando su nombre
    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    // Cierra el juego o aplicación
    public void SalirAplicacion()
    {
        Application.Quit();
        Debug.Log("Saliendo de la aplicación...");
    }
}