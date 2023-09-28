using UnityEngine;

class ObstacleModel
{
    private ObstacleView _view;
    private bool _isMoving;
    private Vector2 _movingDirection; 

    public ObstacleModel(ObstacleView view, bool isMoving, Vector2 movingDirection)
    {
        _view = view;
        _isMoving = isMoving;
        _movingDirection = movingDirection;
    }
}