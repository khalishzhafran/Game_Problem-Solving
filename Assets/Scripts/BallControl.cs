using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float speed;

    Vector2 curScreenPoint;
    Vector2 curPosition;
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();
    }

    void MoveBall()
    {
        curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);

        curPosition += offset;

        transform.Translate(new Vector2(curPosition.x, curPosition.y).normalized * speed * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
    }
}
