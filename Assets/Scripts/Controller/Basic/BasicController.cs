using UnityEngine;

public abstract class BasicController : MonoBehaviour, IMovable, IRotatable
{
    private void Update() =>
        Control();

    public abstract void Move();

    public abstract void Rotate();

    protected virtual void Control()
    {
        Move();
        Rotate();
    }
}
