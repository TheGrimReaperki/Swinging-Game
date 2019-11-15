using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public Vector2 speed = new Vector2(0, 0);

    private Vector2 movement = new Vector2(1, 1);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);

        if (Input.GetKeyDown("space")) //and check if on around
        {
            //transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 4000));
        }

    }
    void FixedUpdate()
    {
        // 5 - Move the game object
        GetComponent<Rigidbody2D>().velocity = movement;
        //rigidbody2D.AddForce(movement);

    }
}