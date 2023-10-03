using UnityEngine;

class ObstacleModel
{
    public ObstacleView _obstacleView;
    private Vector3 _obstaclePosition;

    public ObstacleModel(ObstacleView obstacleView, Vector3 obstaclePosition)
    {
        _obstacleView = obstacleView;
        _obstaclePosition = obstaclePosition;
    }

    public void SetObstaclePosition(Vector3 obstaclePosition)
    {
        _obstaclePosition = obstaclePosition;
        _obstacleView.SetPosition(obstaclePosition);
    }
}