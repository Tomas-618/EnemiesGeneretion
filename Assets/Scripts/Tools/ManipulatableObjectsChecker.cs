using UnityEngine;

public class ManipulatableObjectsChecker : MonoBehaviour
{
    public Manipulatable Item { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Manipulatable item))
            Item = item;
    }
}
