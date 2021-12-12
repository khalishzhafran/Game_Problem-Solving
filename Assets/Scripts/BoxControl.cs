using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour
{
    public GameObject _prefab;

    private Vector2 _rand;
    
    private int _randAmount;

    // Start is called before the first frame update
    void Start()
    {
        CallBox();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallBox()
    {
        _randAmount = Random.Range(1, 10);

        for (int i = 0; i <= _randAmount; i++)
        {
            float randXPos = Random.Range(-7.5f, 7.5f);
            float randYPos = Random.Range(-3.5f, 3.5f);

            _rand = new Vector2(randXPos, randYPos);

            Instantiate(_prefab, _rand, Quaternion.identity);
        }
    }
}
