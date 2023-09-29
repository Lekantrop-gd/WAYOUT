using UnityEngine;

class ObstacleView : MonoBehaviour, IObstacle
{
    [SerializeField] private bool _isMoving;
    [SerializeField] private Vector2 _movingDirection;

    private ObstaclePresenter _presenter;
    private ObstacleModel _model;

    public void Destroy()
    {
        Destroy(gameObject);
    }

    private void Awake()
    {
        _model = new ObstacleModel(this, _isMoving, _movingDirection);
        _presenter = new ObstaclePresenter(_model);
    }

    private void Update()
    {
        _presenter.GetPosition();
    }
}