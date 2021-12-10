using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;

    public float xInitialForce = 30;
    public float yInitialForce = 15;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

        PushBall();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PushBall()
    {
        float xRandomInitialForce = Random.Range(-xInitialForce, xInitialForce);
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

        //float randomDirection = Random.Range(0, 2);

        rigidBody2D.AddForce(new Vector2(xRandomInitialForce, yRandomInitialForce).normalized * xInitialForce);
    }
}
