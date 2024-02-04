using UnityEngine;

public class SuperKick : MonoBehaviour
{
    private Transform _transform;
    private float _force;
    private float _radius;

    private void Awake()
    {
        _transform = transform;
        _force = 800;
        _radius = 5;
    }

    private void UsePower()
    {
        Collider[] others = Physics.OverlapSphere(_transform.position, _radius);

        foreach (Collider other in others)
        {
            if (other.TryGetComponent(out Rigidbody rigidbody))
            {
                rigidbody.AddExplosionForce(_force, _transform.position, _radius);
            }
        }
    }
}
