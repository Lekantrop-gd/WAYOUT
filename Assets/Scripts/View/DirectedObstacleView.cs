using System.Collections;
using UnityEngine;


public class DirectedObstacleView : View
{
    [SerializeField] private bool _isMoving;
    [SerializeField] private MovementDirection _movementDirection;
    [SerializeField] private float _movementDistance;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _delay;

    private DirectedObstaclePresenter _presenter;
    private DirectedObstacleModel _model;

    private void Awake()
    {
        _model = new DirectedObstacleModel(this, transform.position);
        _presenter = new DirectedObstaclePresenter(_model);
        _presenter.InitializeMove(_movementDirection, transform.position, _movementDistance);
    }

    private IEnumerator StartMovement()
    {
        while (true)
        {
            _presenter.Move(transform.position, _movementSpeed);
            yield return new WaitForEndOfFrame();
        }
    }

    private IEnumerator StartMovementOnDelay()
    {
        yield return new WaitForSeconds(_delay);
        StartCoroutine(StartMovement());
    }

    private void OnBecameVisible()
    {
        StartCoroutine(StartMovementOnDelay());
    }
}

enum MovementDirection
{
    up,
    down,
    left,
    right
}