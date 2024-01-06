using UnityEngine;

public abstract class ObstacleModel
{
    protected Vector3 _position;
    protected View _view;

    public ObstacleModel(Vector3 positoin, View view)
    {
        _position = positoin;
        _view = view;
    }

    public virtual void SetPosition(Vector3 position)
    {
        _position = position;
        _view.UpdateView(position);
    }
}