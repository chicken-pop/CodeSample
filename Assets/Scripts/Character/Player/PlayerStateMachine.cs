public class PlayerStateMachine
{
    private PlayerState _CurrentState;

    public void initialize(PlayerState initState)
    {
        _CurrentState = initState;
        _CurrentState.Enter();
    }

    public void changeState(PlayerState newState)
    {
        _CurrentState.Exit();
        _CurrentState = newState;
        _CurrentState.Enter();
    }

    public void updateState() => _CurrentState.Update();

}
