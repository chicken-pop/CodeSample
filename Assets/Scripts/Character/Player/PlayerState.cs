using UnityEngine;

public abstract class PlayerState
{
    protected Player Player { get; } 

    public PlayerState(Player player)
    {
        Player = player;
    }

    public virtual void Enter()
    {
        // Code to execute when entering the state
    }

    public virtual void Update()
    {
        Player.setInputDirection(new Vector2(Input.GetAxisRaw("Horizontal"), 0));
    }

    public virtual void Exit()
    {
        // Code to execute when exiting the state
    }
}
