using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rain : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 1.5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "UmbrellaWall")
        {
            Destroy(gameObject);
        }
    }
}
