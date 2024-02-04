using UnityEngine;
using UnityEngine.Events;

public class EnemyBehavior : BasicController
{
    public event UnityAction PlayerReachedFinalPoint;

    private Transform[] _arrivePoints;
    private Transform _transform;
    private int _currentArrivePointIndex;
    private float _speed;

    public bool IsArrive => _transform.position == _arrivePoints[_currentArrivePointIndex].position;

    private void Awake()
    {
        _transform = transform;
        _speed = 2;
    }

    public void Init(Transform[] arrivesPoints) =>
        _arrivePoints = arrivesPoints;

    public override void Move() =>
        _transform.position = Vector3.MoveTowards(_transform.position, GetCurrentArrivePoint(), _speed * Time.deltaTime);

    public override void Rotate() =>
        _transform.LookAt(GetCurrentArrivePoint());

    protected override void Control()
    {
        if (IsArrive && _currentArrivePointIndex == _arrivePoints.Length.DecreaseByOne())
        {
            PlayerReachedFinalPoint?.Invoke();
            enabled = false;
        }

        base.Control();
    }

    private Vector3 GetCurrentArrivePoint()
    {
        _currentArrivePointIndex += System.Convert.ToInt32(IsArrive);
        _currentArrivePointIndex = Mathf.Clamp(_currentArrivePointIndex, 0, _arrivePoints.Length.DecreaseByOne());

        return _arrivePoints[_currentArrivePointIndex].position;
    }
}
