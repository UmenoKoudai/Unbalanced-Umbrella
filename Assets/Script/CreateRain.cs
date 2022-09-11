using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CreateRain : MonoBehaviour
{
    [SerializeField] GameObject _rain;
    [SerializeField] float _intarval;
    [SerializeField] bool _rainPositiopn;
    BoxCollider2D _bc;
    float _timer;

    private void Start()
    {
        _bc = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        _timer += Time.deltaTime;
        float randamX = Random.Range((-_bc.size.x) / 2, (_bc.size.x) / 2);
        float randamY = Random.Range((-_bc.size.y) / 2, (_bc.size.y) / 2);
        if (_timer >= _intarval)
        {
            GameObject rain = Instantiate(_rain);
            rain.transform.position = new Vector2(transform.position.x + randamX, transform.position.y + (_bc.offset.y) / 2 + (_bc.size.y) / 2);
            //if (_rainPositiopn)
            //{
            //    rain.transform.position = new Vector2(transform.position.x + randamX, transform.position.y + randamY);
            //}
            //else
            //{
            //    rain.transform.position = new Vector2(transform.position.x + randamX, transform.position.y + (_bc.offset.y) / 2 + (_bc.size.y) / 2);
            //}
            rain.transform.SetParent(transform);
            _timer = 0;
        }
    }
}
