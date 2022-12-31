using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
    private float duration = 5f;
    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        Debug.Log("Enter");
    }

    public override void Exit()
    {
        Debug.Log("Exit");

    }

    public override void Tick(float deltaTime)
    {
        duration -= deltaTime; 

        Debug.Log(duration);

        if(duration <= 0)
        {
            stateMachine.SwithState(new PlayerTestState(stateMachine));
        }
    }
}
