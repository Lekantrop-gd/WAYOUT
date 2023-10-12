using UnityEngine;

public abstract class ObstacleModel
{
    protected Vector3 _positoin;
    protected View _view;

    public ObstacleModel(Vector3 positoin, View view)
    {
        _positoin = positoin;
        _view = view;
    }

    public virtual void SetPosition(Vector3 position)
    {
        _positoin = position;
        _view.UpdateView(position);
    }
}