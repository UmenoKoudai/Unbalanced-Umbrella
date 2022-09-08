using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]Text _scoreText;
    [SerializeField]Image _umbrellaFull;
    [SerializeField] GameObject _umbrellaFullPrefab;
    [SerializeField] GameObject _scoreCountPanel;
    [SerializeField] GameObject _umbrellaHead;

    int _score;
    int _fullUmbrellaCount;

    void Update()
    {
        _scoreText.text = $"{_score}";
        if(_score >= 100)
        {
            _fullUmbrellaCount++;
            _umbrellaFull.fillAmount = 0;
            _score = 0;
            GameObject umbrellaFull = Instantiate(_umbrellaFullPrefab);
            umbrellaFull.transform.SetParent(_scoreCountPanel.transform);
        }
        if(_umbrellaHead.transform.rotation.z > 90)
        {
            _score = 0;
            _umbrellaFull.fillAmount = 0;
        }
    }
    public void AddScore(int score)
    {
        _score += score;

    }
}
enum HeavyRain
{
    NormalRain,
    HeavyRain,
}
