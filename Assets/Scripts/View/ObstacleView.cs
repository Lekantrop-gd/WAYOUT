using UnityEngine;

class ObstacleView : MonoBehaviour, IObstacle
{
    [SerializeField] private bool _isMoving;
    [SerializeField] private Vector2 _movingDirection;

    private ObstaclePresenter _presenter;

    public void Destroy()
    {
        Destroy(gameObject);
    }
}