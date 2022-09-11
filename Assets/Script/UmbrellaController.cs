using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UmbrellaController : MonoBehaviour
{
    [SerializeField] int _score;
    [SerializeField] Image _umbrellaFull;
    [SerializeField] Transform _playerPotition;
    Rigidbody2D _rb;
    PlayerController _player;
    GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _player = GameObject.FindObjectOfType<PlayerController>();
        _gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_playerPotition.position.x, _playerPotition.position.y + 2.5f, 0f);
        float x = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector2(x, 0f) * _player.MoveSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Rain")
        {
            _umbrellaFull.fillAmount += 0.01f;
            _gameManager.AddScore(_score);
            Destroy(collision.gameObject);
        }
    }
}
