using UnityEngine;

public class ObstacleView : View
{
    [SerializeField] private bool _isMoving;
    [SerializeField] private MovementDirection _movementDirection;
    [SerializeField] private float _movementDistance;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private bool _isLooped;

    private ObstaclePresenter _presenter;
    private ObstacleModel _model;

    public void Destroy()
    {
        Destroy(gameObject);
    }

    private void Awake()
    {
        _model = new ObstacleModel(this, transform.position);
        _presenter = new ObstaclePresenter(_model);
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