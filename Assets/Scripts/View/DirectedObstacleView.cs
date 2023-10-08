using UnityEngine;

public class DirectedObstacleView : View
{
    [SerializeField] private bool _isMoving;
    [SerializeField] private MovementDirection _movementDirection;
    [SerializeField] private float _movementDistance;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private bool _isLooped;

    private DirectedObstaclePresenter _presenter;
    private DirectedObstacleModel _model;

    public void Destroy()
    {
        Destroy(gameObject);
    }

    private void Awake()
    {
        _model = new DirectedObstacleModel(this, transform.position);
        _presenter = new DirectedObstaclePresenter(_model);
        _presenter.InitializeMove(_movementDirection, transform.position, _movementDistance);
    }

    private void Update()
    {
        if (_isMoving)
        {
            _presenter.Move(transform.position, _movementSpeed);
        }
    }
}

enum MovementDirection
{
    up,
    down,
    left,
    right
}