using UnityEngine;

[RequireComponent(typeof(EnemyBehavior), typeof(Animator))]
public class AnimationsController : MonoBehaviour
{
    private EnemyBehavior _enemy;
    private Animator _animator;

    private void Awake()
    {
        _enemy = GetComponent<EnemyBehavior>();
        _animator = GetComponent<Animator>();
    }

    private void OnEnable() =>
        _enemy.PlayerReachedFinalPoint += Example;

    private void OnDisable() =>
        _enemy.PlayerReachedFinalPoint -= Example;

    private void Example() =>
        _animator.SetTrigger(AnimatorData.Params.IsArrived);
}
