using UnityEngine;

class ObstaclePresenter
{
    private ObstacleModel _model;

    public ObstaclePresenter(ObstacleModel model)
    {
        _model = model;
    }

    public int GetPosition()
    {
        return 12;
    }
}