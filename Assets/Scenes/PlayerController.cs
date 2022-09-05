using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform _umbrella;
    [SerializeField] int _moveSpeed;
    [SerializeField] float _timeToAngle;
    Rigidbody2D _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
;    }

    void Update()
    {
        float X = Input.GetAxisRaw("Horizontal");
        float RandamZ = Random.Rnage(-1, 1);
        Vector2 dir = new Vector2(X, 0f);
        if(dir.magnitude != 0)
        {
            _umbrella.Rotate(0f, 0f, X * _timeToAngle * Time.deltaTime);
            transform.right = dir;
        }
        else
        {
            _umbrella.Rotate(0f, 0f, X * _timeToAngle * Time.deltaTime);
        }
        _umbrella.Rotate(0f, 0f, X * _timeToAngle * Time.deltaTime);
        _rb.velocity = new Vector2(X, 0f) * _moveSpeed;
;    }
}
