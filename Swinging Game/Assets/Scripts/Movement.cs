using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    bool isGrounded = true;

    private float jumpForce = 2f;
    private Rigidbody2D pRigidBody;

    void Start()
    {
        pRigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //Debug.Log("test");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000));
            //pRigidBody.AddForce(new Vector3(0, jumpForce, 0));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exited");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
