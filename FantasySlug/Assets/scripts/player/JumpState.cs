using UnityEngine;
using System.Collections;

public class JumpState : IPlayerState {

	private readonly StatePatternPlayer player;

    public JumpState (StatePatternPlayer statePatternPlayer)
    {

        player = statePatternPlayer;

    }

    public void updateState()
    {


    }

    public void OnTriggerEnter(Collider other)
    {


    }

    public void toMoveState()
    {

        player.currentState = player.moveState;

    }

    public void toIdleState()
    {

        player.currentState = player.idleState;

    }

    public void toJumpState()
    {

        Debug.Log("JumpState.cs: You're already in Jump State!");

    }

    public void toAttackState()
    {

        player.currentState = player.attackState;

    }
}
