using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    bool isGrounded = true;

    //private float jumpForce = 2f;
    private Rigidbody2D pRigidBody;

    void Start()
    {
        pRigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //Debug.Log("can jump");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1200));
            //pRigidBody.AddForce(new Vector3(0, jumpForce, 0));
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Entered");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exited");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
