using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private PlayerMovementView _movementView;
    [SerializeField] private float _horizontalSpeed;
    [SerializeField] private float _verticalSpeed;

    public void Move(Vector3 pointerPosition)
    {
        Vector3 startPosition = transform.position;
        Vector3 endPosition = new Vector3(pointerPosition.x, transform.position.y + _verticalSpeed);

        Vector3 position = Vector3.MoveTowards(startPosition, endPosition, _horizontalSpeed * Time.deltaTime);
        _movementView.SetPosition(position);
    }
}
