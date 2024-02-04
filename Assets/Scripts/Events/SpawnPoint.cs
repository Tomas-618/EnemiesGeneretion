using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform[] _arrivePoints;
    [SerializeField] private EnemyBehavior _enemy;

    private Transform _transform;

    private void Awake() =>
        _transform = transform;

    public void Spawn()
    {
        EnemyBehavior enemy = Instantiate(_enemy, _transform.position, Quaternion.identity);

        enemy.Init(_arrivePoints);
    }
}
