using UnityEngine;

public class CameraMovementController : MonoBehaviour
{
    [SerializeField] private CameraMovementView _camera;
    [SerializeField] private PlayerMovementView _player;
    [SerializeField] private float _offset;
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 startPosition = transform.position;
        Vector3 endPosition = new Vector3(transform.position.x, _player.transform.position.y - _offset, transform.position.z);
        Vector3 position = Vector3.MoveTowards(startPosition, endPosition, _speed * Time.deltaTime);
        _camera.SetPosition(position);
    }
}
