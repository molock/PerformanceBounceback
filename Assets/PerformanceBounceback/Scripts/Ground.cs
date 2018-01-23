using UnityEngine;

public class Ground : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            col.gameObject.SetActive(false);
        }

    }

} 