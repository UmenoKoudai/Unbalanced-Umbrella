using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UmbrellaController : MonoBehaviour
{
    [SerializeField] Transform _rigthEnd;
    [SerializeField] Transform _leftEnd;
    [SerializeField]Transform _player;
    [SerializeField] float _rotateTime;
    void Start()
    {
        //_player = GameObject.FindGameObjectWithTag("Player");
        //_rigthEnd.rotation = Quaternion.Euler(0f, 0f, 90f);
        //_leftEnd.rotation = Quaternion.Euler(0f, 0f, -90f);
    }

    void Update()
    {
        //if(transform.position.magnitude > _player.position.magnitude)
        //{
        //    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90f);
        //}
        //else if(transform.position.magnitude < _player.position.magnitude)
        //{
        //    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -90f);
        //}
        float X = Input.GetAxisRaw("Horizontal");

    }
}
