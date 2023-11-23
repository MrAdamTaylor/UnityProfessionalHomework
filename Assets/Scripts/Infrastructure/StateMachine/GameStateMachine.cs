using System;
using System.Collections.Generic;
using Infrastructure.Services;

namespace Infrastructure.StateMachine
{
    internal class GameStateMachine
    {
        private readonly Dictionary<Type, IState> _states;
        private IState _currentState;
        public GameStateMachine(ServiceAllocator services)
        {
            _states = new Dictionary<Type, IState>
            {
                [typeof(BootstrapState)] = new BootstrapState(this, services),
                [typeof(LoadDataState)] = new LoadDataState(this),
                [typeof(GameLoopState)] = new GameLoopState(this)
            };
        }
    
        public void Enter<TState>() where TState : class, IState
        {
            IState myState = ChangeState<TState>();
            myState.Enter();
        }

    
        private IState ChangeState<TState>() where TState : class, IState
        {
            _currentState?.Exit();
            TState myState = GetState<TState>();
            _currentState = myState;
            return myState;
        }

        private TState GetState<TState>() where TState : class, IState
        {
            return _states[typeof(TState)] as TState;
        }
    }
}