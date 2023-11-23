using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using ShootEmUp;
using UnityEngine;

public class ManagerPlayerMediator : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    [SerializeField] private PlayerController _playerController;

    private void FixedUpdate()
    {
        if (_playerController._fireRequired)
        {
            _gameManager.OnFlyBullet();
            _playerController._fireRequired = false;
        }
    }
}
