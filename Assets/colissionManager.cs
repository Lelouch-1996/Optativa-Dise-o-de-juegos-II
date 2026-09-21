using UnityEngine;

public class colissionManager : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("touched something");
    }
}