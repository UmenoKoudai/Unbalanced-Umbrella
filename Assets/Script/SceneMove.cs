using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    [SerializeField] GameObject _open;
    [SerializeField] GameObject _close;
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public void SetActive()
    {
        _close.gameObject.SetActive(false);
        _open.gameObject.SetActive(true);
    }
}
