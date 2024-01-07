using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Tail : View
{
    [SerializeField] private Transform _head;
    [SerializeField] private int _startLenght;
    [SerializeField] private float _followingSpeed;
    
    private LineRenderer _tail;
    private Vector3[] _tailElements;

    private void Awake()
    {
        _tail = GetComponent<LineRenderer>();
        _tail.positionCount = _startLenght;
        
        _tailElements = new Vector3[_startLenght];
        _tail.GetPositions(_tailElements);
    }

    private void Update()
    {
        _tailElements[0] = _head.position;

        for (int x = 1; x < _tailElements.Length; x++)
        {
            _tailElements[x] = Vector3.Lerp(_tailElements[x], _tailElements[x - 1], Time.deltaTime * _followingSpeed);
        }

        _tail.SetPositions(_tailElements);
    }

    public void IncreaseLenght()
    {
        _tail.positionCount++;
        _tail.SetPosition(_tail.positionCount - 1, _tail.GetPosition(_tail.positionCount - 2));
        
        _tailElements = new Vector3[_tail.positionCount];
        _tail.GetPositions(_tailElements);
    }
}
