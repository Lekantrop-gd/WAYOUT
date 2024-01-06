using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerView : View
{
    [SerializeField] private Tail _tail;
    [SerializeField] private float _verticalSpeed;
    [SerializeField] private float _horizontalSpeed;

    private PlayerModel _model;
    private PlayerPresenter _presenter;

    private void Awake()
    {
        _model = new PlayerModel(transform.position, this);
        _presenter = new PlayerPresenter(_model, _verticalSpeed, _horizontalSpeed);
    }

    private void Update()
    {
        Vector3 pointerPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _presenter.Move(transform.position, pointerPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Food>(out var food))
        {
            Destroy(food.gameObject);
        }

        if (collision.gameObject.TryGetComponent<ObstacleView>(out var obstacle))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}