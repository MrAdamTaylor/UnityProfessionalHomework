using System;

namespace Infrastructure.StateMachine
{
    internal class LoadDataState : IState
    {
        private readonly GameStateMachine _stateMachine;

        public LoadDataState(GameStateMachine gameStateMachine)
        {
            _stateMachine = gameStateMachine;
        }

        public void Enter()
        {
            throw new NotImplementedException();
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }
    }
}