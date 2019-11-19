using UnityEngine;

public class TouchingFire : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("test");
        Destroy(gameObject);
    }
}