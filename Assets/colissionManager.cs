using UnityEngine;

public class colissionManager : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("touched something");
    }
}