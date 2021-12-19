using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    Text _timeText;
    BallControl _ball;
    GameManager _pool;

    public GameObject _gameOver;
    public Text _finalScoreText;

    public float _duration;
    public bool isGameOver;

    private int _time;

    // Start is called before the first frame update
    void Start()
    {
        _timeText = GetComponent<Text>();
        _ball = BallControl.Instance.gameObject.GetComponent<BallControl>();
        _pool = GameManager.Instance.gameObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        TimeRemaining();

        SetGameOver();
    }

    private void TimeRemaining()
    {
        _duration -= Time.deltaTime;

        _time = Mathf.FloorToInt(_duration) + 1;

        _timeText.text = _time.ToString();
    }

    private void SetGameOver()
    {
        if (_time <= 0)
        {
            enabled = false;
            _ball.enabled = false;
            _pool.enabled = false;

            int finalTime = 0;
            _timeText.text = finalTime.ToString();

            _gameOver.SetActive(true);

            _finalScoreText.text = ScoreManager._score.ToString();
        }
    }
}
