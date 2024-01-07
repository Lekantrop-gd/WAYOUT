using UnityEngine;

public abstract class Model
{
    private View _view;
    private Vector3 _position;

    public Model(Vector3 positoin, View view)
    {
        _position = positoin;
        _view = view;
    }

    public virtual void SetPosition(Vector3 position)
    {
        _position = position;
        _view.UpdateView(_position);
    }
}