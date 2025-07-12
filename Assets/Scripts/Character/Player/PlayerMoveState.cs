using UnityEngine;

public class PlayerMoveState : PlayerState
{

    public PlayerMoveState(Player player) : base(player)
    {

    }
    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        base.Update();

        if (Player.InputDirection == Vector2.zero)
        {
            Player.StateMachine.changeState(Player.IdleState);
        }
        else
        {
            Player.move();
        }
    }

    public override void Exit()
    {
        base.Exit();
    }
}
