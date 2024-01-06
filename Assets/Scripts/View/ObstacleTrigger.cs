using UnityEngine;
using UnityEngine.Events;

public class ObstacleTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent _onTriggerReached;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMovementView player = collision.gameObject.GetComponent<PlayerMovementView>();
        if (player != null)
        {
            _onTriggerReached?.Invoke();
        }
        Destroy(gameObject);
    }
}