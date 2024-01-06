using UnityEngine;

public abstract class Model
{
    private Vector3 _position;
    private View _view;

    public Model(Vector3 positoin, View view)
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