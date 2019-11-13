using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        // Move the object upward in world space 1 unit/second.
        transform.Translate(Vector3.left * Time.deltaTime, Space.World);
    }
}