using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Result : MonoBehaviour
{
    [SerializeField] float _scoreChangeIntarval;
    Animator _anim;
    Text _resultText;
    int _result;
    void Start()
    {
        _resultText = GetComponent<Text>();
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        //DOTween.To(() => _result, x => _result = x, GameManager._fullUmbrellaCount * 100, _scoreChangeIntarval).OnUpdate(() => _resultText.text = $"{_result}");
        //DOTween.To(() => _result, x => _result = x, 5000, _scoreChangeIntarval).OnUpdate(() => _resultText.text = $"{_result}");
        StartCoroutine(ResuleCount());
    }
    IEnumerator ResuleCount()
    {
        DOTween.To(() => _result, x => _result = x, 5000, _scoreChangeIntarval).OnUpdate(() => _resultText.text = $"{_result}").OnComplete(() => _resultText.text = $"{5000}");
        yield return new WaitForSeconds(1f);
        _anim.Play("Result");
    }
}
