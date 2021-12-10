using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float speed = 10.0f;
 
    private Rigidbody2D rigidBody2D;

    private KeyCode upButton = KeyCode.W;
    private KeyCode downButton = KeyCode.S;
    private KeyCode leftButton = KeyCode.A;
    private KeyCode rightButton = KeyCode.D;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();
    }

    void MoveBall()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(horizontal, vertical) * speed * Time.deltaTime);
    }
}
