using UnityEngine;

public abstract class MovementView : MonoBehaviour
{
    public virtual void SetPosition(Vector3 position) 
    {
        transform.position = position;
    }
}
