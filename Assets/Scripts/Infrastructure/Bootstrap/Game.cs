using Infrastructure.Services;
using Infrastructure.StateMachine;

namespace Infrastructure.Bootstrap
{
    internal class Game
    {
        public GameStateMachine StateMachine;

        public Game()
        {
            StateMachine = new GameStateMachine(ServiceAllocator.Container);
        }
    }
}