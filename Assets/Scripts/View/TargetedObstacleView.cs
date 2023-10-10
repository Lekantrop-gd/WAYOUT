using System.Collections;
using UnityEngine;

public class TargetedObstacleView : View
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private bool _isLoooped;

    private TargetedObstaclePresenter _presenter;
    private TargetedObstacleModel _model;
    private Mesh _mesh;

    private void Awake()
    {
        _mesh = GetComponent<Mesh>();
        _model = new TargetedObstacleModel(transform.position, _target.position, this);
        _presenter = new TargetedObstaclePresenter(_model);
    }

    private IEnumerator StartMoving()
    {
        while (true)
        {
            _presenter.Move(transform.position, _target.position, _speed);
            yield return new WaitForEndOfFrame();
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

    public void StartMovement()
    {
        StartCoroutine(StartMoving());
    }
}