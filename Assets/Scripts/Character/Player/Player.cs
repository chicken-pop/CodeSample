using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _MoveSpeed = 5f;

    private PlayerStateMachine _StateMachine;
    public PlayerStateMachine StateMachine => _StateMachine;

    #region States
    private PlayerIdleState _IdleState;
    public PlayerIdleState IdleState => _IdleState;
    private PlayerMoveState _MoveState;
    public PlayerMoveState MoveState => _MoveState;
    #endregion

    private Vector2 _InputDirection;
    public Vector2 InputDirection => _InputDirection;

    private void Start()
    {
        _StateMachine = new PlayerStateMachine();
        _IdleState = new PlayerIdleState(this);
        _MoveState = new PlayerMoveState(this);

        _StateMachine.initialize(_IdleState); // ‰Šúó‘Ô‚ğIdle‚Éİ’è
    }

    private void Update()
    {
        _StateMachine.updateState();
    }

    public void setInputDirection(Vector2 direction)
    {
        _InputDirection = direction;
    }

    public void move()
    {
        gameObject.transform.position += new Vector3(_InputDirection.x, 0, _InputDirection.y) * _MoveSpeed * Time.deltaTime;
    }
}
