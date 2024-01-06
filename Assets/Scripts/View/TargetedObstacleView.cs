using System.Collections;
using UnityEngine;

public class TargetedObstacleView : ObstacleView
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private bool _isLoooped;

    private TargetedObstaclePresenter _presenter;
    private TargetedObstacleModel _model;

    private void Awake()
    {
        _model = new TargetedObstacleModel(this, transform.position, _target.position);
        _presenter = new TargetedObstaclePresenter(_model, _speed);
    }

    private IEnumerator StartMoving()
    {
        while (true)
        {
            _presenter.Move(transform.position, _target.position);
            yield return null;
        }
    }

    public override void UpdateView(Vector3 position)
    {
        transform.position = position;
        
        if ( _isLoooped )
        {
            if (position == _model.EndPosition)
            {
                _target.position = _model.StartPosition;
            }
            else if (position == _model.StartPosition)
            {
                _target.position = _model.EndPosition;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        Gizmos.DrawWireCube(_target.transform.position, new Vector2(collider.bounds.size.x, collider.bounds.size.y));
    }
}