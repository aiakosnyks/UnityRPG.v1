using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public InputReader InputReader {get; private set;};
    void Start()
    {
        SwithState(new PlayerTestState(this));
    }
}
