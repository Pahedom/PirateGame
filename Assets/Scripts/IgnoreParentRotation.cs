using UnityEngine;

public class IgnoreParentRotation : MonoBehaviour
{
    private Transform _parent;

    private Vector3 _refPosition;
    private Quaternion _refRotation;

    private void Start()
    {
        _parent = transform.parent;

        _refPosition = transform.localPosition;
        _refRotation = transform.localRotation;
    }

    private void Update()
    {
        transform.position = _parent.position + _refPosition;
        transform.rotation = _refRotation;
    }
}