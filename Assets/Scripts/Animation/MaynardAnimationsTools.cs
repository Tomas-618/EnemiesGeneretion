using UnityEngine;

public class MaynardAnimationsTools : MonoBehaviour
{
    private Manipulator _point;

    public Manipulatable Item => GetComponentInChildren<ManipulatableObjectsChecker>().Item;

    private void Awake() =>
        _point = GetComponentInChildren<Manipulator>();

    private void Manipulate()
    {
        if (Item.TryGetComponent(out Rigidbody rigidbody))
            rigidbody.isKinematic = true;

        Item.transform.SetParent(_point.transform);
    }

    private void StopManipulating()
    {
        if (Item.TryGetComponent(out Rigidbody rigidbody))
            rigidbody.isKinematic = false;

        Item.transform.SetParent(null);
    }
}
