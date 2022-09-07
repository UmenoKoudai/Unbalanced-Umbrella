using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CreateRain : MonoBehaviour
{
    [SerializeField] GameObject _rain;
    [SerializeField] float _intarval;
    BoxCollider2D _bc;
    float _timer;
    // Start is called before the first frame update
    void Start()
    {
        _bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        float randamX = Random.Range((-_bc.size.x) / 2, (_bc.size.x) / 2);
        float randamY = Random.Range((-_bc.size.y) / 2, (_bc.size.y) / 2);
        if(_timer >= _intarval)
        {
            GameObject rain = Instantiate(_rain);
            rain.transform.position = new Vector2(transform.position.x + randamX, transform.position.y + randamY);
            _timer = 0;
        }
    }
}
