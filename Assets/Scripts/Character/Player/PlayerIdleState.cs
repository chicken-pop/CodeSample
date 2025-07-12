using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(Player player) : base(player)
    {
    }
    public override void Enter()
    {
        base.Enter();
    }
    public override void Update()
    {
        base.Update();
        if (Player.InputDirection != Vector2.zero)
        {
            Player.StateMachine.changeState(Player.MoveState);
        }
    }

    public override void Exit()
    {
        base.Exit();
    }
}
