using UnityEngine;

class Obstacle : MonoBehaviour
{
    [SerializeField] private ObstacleView obstacle;

    private void Awake()
    {
        ObstacleView view = Instantiate(obstacle);
    }
}