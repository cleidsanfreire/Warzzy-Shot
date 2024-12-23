using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float loseEnemy;

    private bool _isGameActive;

    private void Start()
    {
        Instance = this;
        _isGameActive = true;
    }
    private float _gameWidth = 3.70f;

    public float gameWidth { get => _gameWidth; set => _gameWidth = value; }
    public bool isGameActive { get => _isGameActive; set => _isGameActive = value; }
}
