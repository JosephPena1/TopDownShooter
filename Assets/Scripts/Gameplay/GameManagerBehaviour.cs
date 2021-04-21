using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public delegate void GameEvent();

public class GameManagerBehaviour : MonoBehaviour
{
    private float _point = 0;

    public static GameEvent onGameOver;

    [SerializeField]
    private HealthBehaviour _playerHealth;

    [SerializeField]
    private GameObject _gameOverScreen;

    [SerializeField]
    private static bool _gameOver = false;

    public float Point
    {
        get { return _point; }
        set { _point = value; }
    }

    public static bool GameOver
    {
        get { return _gameOver; }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        _gameOver = _playerHealth.Health <= 0;

        _gameOverScreen.SetActive(_gameOver);
    }
}
