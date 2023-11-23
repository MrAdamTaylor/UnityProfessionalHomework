using Infrastructure.StateMachine;
using UnityEngine;

namespace Infrastructure.Bootstrap
{
    public class GameBootstraper : MonoBehaviour
    {
        private Game _game;

        private void Awake()
        {
            _game = new Game();
            _game.StateMachine.Enter<BootstrapState>();
        }
    }
}