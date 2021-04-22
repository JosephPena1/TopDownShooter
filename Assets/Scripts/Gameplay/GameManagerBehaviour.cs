using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public delegate void GameEvent();

public class GameManagerBehaviour : MonoBehaviour
{
    //Holds the number of points the player has collected
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

    //Restarts the scene
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    //Quits the application
    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        //Sets gameOver based on if the player has died or not
        _gameOver = _playerHealth.Health <= 0;
        //Activates the game over screen if gameOver is true
        _gameOverScreen.SetActive(_gameOver);
    }
}
