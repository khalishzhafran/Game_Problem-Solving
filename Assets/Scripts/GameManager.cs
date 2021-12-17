using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<GameObject> _pooledObjects = new List<GameObject>();

    public GameObject _prefab;

    private int _randAmount;
    private bool _isRespawning = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        CreatePool();
        _isRespawning = true;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject box = SpawnFromPool();

        if (box != null && _isRespawning)
        {
            StartCoroutine(RespawnToPool());
        }

    }

    public void CreatePool()
    {
        _randAmount = Random.Range(1, 10);

        for (int i = 0; i < _randAmount; i++)
        {
            float randXPos = Random.Range(-7.5f, 7.5f);
            float randYPos = Random.Range(-3.5f, 3.5f);

            Vector2 _rand = new Vector2(randXPos, randYPos);

            GameObject obj =  Instantiate(_prefab, _rand, Quaternion.identity);

            obj.SetActive(true);

            _pooledObjects.Add(obj);
        }
    }

    public GameObject SpawnFromPool()
    {
        for (int i = 0; i < _pooledObjects.Count; i++)
        {
            if (!_pooledObjects[i].activeInHierarchy)
            {
                return _pooledObjects[i];
            }
        }

        return null;
    }

    private IEnumerator RespawnToPool()
    {
        _isRespawning = false;

        yield return new WaitForSeconds(3);

        float randXPos = Random.Range(-7.5f, 7.5f);
        float randYPos = Random.Range(-3.5f, 3.5f);

        Vector2 _rand = new Vector2(randXPos, randYPos);

        GameObject box = SpawnFromPool();

        if (box != null)
        {
            box.transform.position = _rand;
            box.SetActive(true);
        }

        _isRespawning = true;
    }
}
