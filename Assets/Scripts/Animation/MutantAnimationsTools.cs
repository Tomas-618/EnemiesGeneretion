using UnityEngine;

public class MutantAnimationsTools : MonoBehaviour
{
    private Transform _transform;
    private float _speed;
    private bool _isLanding;

    private void Awake()
    {
        _transform = transform;
        _speed = 3;
        _isLanding = true;
    }

    private void Update() =>
        Move();

    private void Move()
    {
        if (_isLanding)
            return;

        _transform.Translate(Time.deltaTime * _speed * Vector3.forward);
    }

    private void Jump() =>
        _isLanding = false;

    private void Land() =>
        _isLanding = true;
}
