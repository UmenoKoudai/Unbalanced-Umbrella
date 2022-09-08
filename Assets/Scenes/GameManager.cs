using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]Text _scoreText;
    [SerializeField]Image _umbrellaFull;
    GameObject _umbrellaHead;

    int _score;
    int _fullUmbrellaCount;
    // Start is called before the first frame update
    void Start()
    {
        _umbrellaHead = GameObject.Find("UmbrellaHead");
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = $"{_score}";
        if(_score >= 100)
        {
            _fullUmbrellaCount += 1;
            _umbrellaFull.fillAmount = 0;
            _score = 0;
        }
        if(_umbrellaHead.transform.rotation.z > 90 && _umbrellaHead.transform.rotation.z < -90)
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
