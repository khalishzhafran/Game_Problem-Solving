using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int _score;

    Text _scoreText;

    void Start()
    {
        _scoreText = GetComponent<Text>();
        _score = 0;
    }

    void Update()
    {
        _scoreText.text = _score.ToString();
    }
}
