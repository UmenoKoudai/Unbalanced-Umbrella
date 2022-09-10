using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]Text _scoreText;
    [SerializeField]Image _umbrellaFull;
    [SerializeField] GameObject _umbrellaFullPrefab;
    [SerializeField] GameObject _scoreCountPanel;
    [SerializeField] GameObject _umbrellaHead;
    [SerializeField] GameObject _normalRain;
    [SerializeField] GameObject _heavyRain;
    [SerializeField] Text _timerText;
    [SerializeField] GamePlayState _state = GamePlayState.Playing;
    bool _isHeavyRain;
    float _umbrellaAngle;
    int _score;
    public static int _fullUmbrellaCount;
    float _timer = 60f;
    float _jugeIntarval;

    private void Start()
    {
        _fullUmbrellaCount = 0;
    }

    void Update()
    {
        _timerText.text = $"TIME:{_timer.ToString("f2")}";
        if (_state == GamePlayState.Playing)
        {
            _timer -= Time.deltaTime;
            _jugeIntarval += Time.deltaTime;
            _umbrellaAngle = _umbrellaHead.transform.rotation.z;
            _scoreText.text = $"{_score}";
            
            if (_score >= 100)
            {
                _fullUmbrellaCount++;
                _umbrellaFull.fillAmount = 0;
                _score = 0;
                GameObject umbrellaFull = Instantiate(_umbrellaFullPrefab);
                umbrellaFull.transform.SetParent(_scoreCountPanel.transform);
            }
            if (_umbrellaAngle * Mathf.Rad2Deg < 40.51424 && _umbrellaAngle * Mathf.Rad2Deg > -40.51424)
            {
                _score = 0;
                _umbrellaFull.fillAmount = 0;
            }
            if (!_isHeavyRain && _jugeIntarval >= 5f)
            {
                int heavyRainJuge = Random.Range(0, 10);
                Debug.Log(heavyRainJuge);
                if (heavyRainJuge >= 8)
                {
                    StartCoroutine(HeavyRainChange());
                }
                _jugeIntarval = 0f;
            }
            if(_timer <= 0f)
            {
                _state = GamePlayState.GameOver;
            }
        }
        else if(_state == GamePlayState.GameOver)
        {
            _timer = 0;
            if (_fullUmbrellaCount >= 5)
            {
                SceneManager.LoadScene("TrueEnd");
            }
            else
            {
                SceneManager.LoadScene("BadEnd");
            }
        }
    }
    public void AddScore(int score)
    {
        _score += score;

    }
    IEnumerator HeavyRainChange()
    {
        _normalRain.gameObject.SetActive(false);
        _heavyRain.gameObject.SetActive(true);
        _isHeavyRain = true;
        yield return new WaitForSeconds(10f);
        _heavyRain.gameObject.SetActive(false);
        _normalRain.gameObject.SetActive(true);
        _isHeavyRain = false;
    }
}
enum GamePlayState
{
    Playing,
    GameOver,
}
