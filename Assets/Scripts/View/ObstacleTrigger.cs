using UnityEngine;
using UnityEngine.Events;

public class ObstacleTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent _onTriggerReached;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.TryGetComponent<PlayerView>(out var player))
            {
                _onTriggerReached?.Invoke();
                Destroy(gameObject);
            }
        }
    }
}