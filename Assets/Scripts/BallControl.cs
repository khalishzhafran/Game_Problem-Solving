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

        //transform.position = curPosition;

        //if (new Vector2(transform.position.x, transform.position.y) != curScreenPoint)
        //{
            transform.Translate(new Vector2(curPosition.x, curPosition.y).normalized * speed * Time.deltaTime);
        //}
        //else
        //{
        //    transform.Translate(new Vector2(0, 0));
        //}
    }

    private void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
    }

    //private void OnMouseDrag()
    //{
    //    Vector2 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

    //    Vector2 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);

    //    curPosition += offset;

    //    //transform.position = curPosition;
    //    transform.Translate(new Vector2(curPosition.x, curPosition.y) * speed * Time.deltaTime);
    //}
}
