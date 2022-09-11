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
        StartCoroutine(ResuleCount());
    }

    IEnumerator ResuleCount()
    {
        _resultText.DOCounter(_result, GameManager._totalScore, 1f);
        yield return new WaitForSeconds(1.5f);
        _anim.Play("Result");
    }
}
