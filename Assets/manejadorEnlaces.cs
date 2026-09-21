using UnityEngine;

public class ManejadorEnlaces : MonoBehaviour
{
    // Esta función recibe una dirección web y la abre en el navegador predeterminado
    public void AbrirSitioWeb(string url)
    {
        Application.OpenURL(url);
    }
}