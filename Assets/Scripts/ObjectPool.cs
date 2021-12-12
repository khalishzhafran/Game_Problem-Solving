using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;
    public List<GameObject> poolObjects;
    public GameObject prefab;
    private int randAmount;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        poolObjects = new List<GameObject>();
        GameObject tmp;
        randAmount = Random.Range(0, 10);
        
        for (int i = 0; i < randAmount; i++)
        {
            tmp = Instantiate(prefab);
            tmp.SetActive(false);
            poolObjects.Add(tmp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject PoolingObject()
    {
        for (int i = 0; i < randAmount; i++)
        {
            if (!poolObjects[i].activeInHierarchy)
            {
                return poolObjects[i];
            }
        }

        return null;
    }

    public void GenerateBox()
    {
        GameObject bullet = PoolingObject();

        int positionX = Random.Range(-Screen.width / 2, Screen.width / 2);
        int positionY = Random.Range(-Screen.height / 2, Screen.height / 2);

        if (bullet != null)
        {
            bullet.transform.position = new Vector2(positionX, positionY);
            bullet.SetActive(true);
        }
    }
}
