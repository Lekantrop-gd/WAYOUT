using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
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
        yield return new WaitForSeconds(_delay);
        while (true)
        {
            _presenter.Move(transform.position, _movementSpeed);
            yield return new WaitForEndOfFrame();
        }
    }

    private void OnBecameVisible()
    {
        StartCoroutine(StartMovement());
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        if (collider != null)
        {
            if (_movementDirection == MovementDirection.up)
            {
                Gizmos.DrawWireCube(new Vector2(transform.position.x, transform.position.y + _movementDistance), collider.bounds.size);
            }
            if (_movementDirection == MovementDirection.down)
            {
                Gizmos.DrawWireCube(new Vector2(transform.position.x, transform.position.y - _movementDistance), collider.bounds.size);
            }
            if (_movementDirection == MovementDirection.right)
            {
                Gizmos.DrawWireCube(new Vector2(transform.position.x + _movementDistance, transform.position.y), collider.bounds.size);
            }
            if (_movementDirection == MovementDirection.left)
            {
                Gizmos.DrawWireCube(new Vector2(transform.position.x - _movementDistance, transform.position.y), collider.bounds.size);
            }
        }
        
    }
}

enum MovementDirection
{
    up,
    down,
    left,
    right
}