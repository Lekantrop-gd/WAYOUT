using UnityEngine;

public abstract class View : MonoBehaviour
{
    public virtual void SetPosition(Vector3 position) {
        transform.position = position;
    }
}
