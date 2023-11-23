using System;
using Infrastructure.Services;

namespace Infrastructure.StateMachine
{
    internal class BootstrapState : IState
    {
        private readonly ServiceAllocator _serviceAllocator;
        private readonly GameStateMachine _stateMachine;

        public BootstrapState(GameStateMachine gameStateMachine, ServiceAllocator serviceAllocator)
        {
            _stateMachine = gameStateMachine;
            _serviceAllocator = serviceAllocator;
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