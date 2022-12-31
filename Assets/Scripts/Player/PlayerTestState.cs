using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
    private float duration;
    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        stateMachine.InputReader.JumpEvent += OnJump;
    }

    public override void Exit()
    {
        stateMachine.InputReader.JumpEvent -= OnJump;

    }

    public override void Tick(float deltaTime)
    {
        duration += deltaTime; 

        Debug.Log(duration);

    }

    public void OnJump()
    {
        stateMachine.SwitchState(new PlayerTestState(stateMachine));

    }
}
