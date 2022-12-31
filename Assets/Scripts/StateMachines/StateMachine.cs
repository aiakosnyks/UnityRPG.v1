using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    private State currentState;

    public void SwithState(State newState)
    {
            currentState?.Exit();
            currentState = newState;
            currentState?.Enter();
    }

    private void Update()
    {
        currentState?.Tick(Time.deltaTime);
        //Does not work with mono behavior.
    }
    
}