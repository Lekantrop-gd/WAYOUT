using UnityEngine;

class ObstacleModel
{
    public View _view;
    private Vector3 _obstaclePosition;

    public ObstacleModel(View obstacleView, Vector3 obstaclePosition)
    {
        _view = obstacleView;
        _obstaclePosition = obstaclePosition;
    }

    public void SetObstaclePosition(Vector3 obstaclePosition)
    {
        _obstaclePosition = obstaclePosition;
        _view.SetPosition(obstaclePosition);
    }
}