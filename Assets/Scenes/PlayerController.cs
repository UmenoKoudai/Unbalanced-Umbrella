using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
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
    float _rotationX;

    public int MoveSpeed { get => _moveSpeed; }
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
;    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        Vector2 dir = new Vector2(x, 0f);
        if(dir.magnitude != 0)
        {
            _rotationX = x;
            _umbrella.Rotate(0f, 0f, x * _timeToAngle);
            transform.right = dir;
        }
        else
        {
            _umbrella.Rotate(0f, 0f, -_rotationX * _timeToAngle);
        }
        _rb.velocity = new Vector2(x, 0f) * _moveSpeed;
;    }
}
