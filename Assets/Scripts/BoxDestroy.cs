using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    public static BoxDestroy Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.isTrigger = true;

            gameObject.SetActive(false);

            ScoreManager._score++;

            collision.isTrigger = false;
        }
    }
}
