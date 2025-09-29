using System.Collections;
using UnityEngine;
using System.Collections.Generic;

namespace Player.AI
{
    public class StateManager : MonoBehaviour
    {
        public State currentState;

        void Update()
        {

            RunStateMachine();
        }

        private void RunStateMachine()
        {
            State nextState = currentState?.RunCurrentState();

            if (nextState != null)
            {
                SwitchToNextState(nextState);
            }
        }

        private void SwitchToNextState(State nextState)
        {
            currentState = nextState;
        }
    }
}