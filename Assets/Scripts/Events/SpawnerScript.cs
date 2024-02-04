using System.Collections;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField, Min(0)] private float _delay;

    private SpawnPoint[] _points;

    private void Reset() =>
        _delay = 2;

    private void Awake() =>
        _points = GetComponentsInChildren<SpawnPoint>();

    private void Start() =>
        StartCoroutine(CreateEnemy(_delay));

    private IEnumerator CreateEnemy(float delay)
    {
        WaitForSeconds wait = new WaitForSeconds(delay);

        foreach (SpawnPoint point in _points)
        {
            yield return wait;

            point.Spawn();
        }
    }
}
