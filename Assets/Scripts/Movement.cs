using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    public float moveSpeed;
    public float rotateSpeed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void MoveForward(float axis)
    {
        _rigidbody.velocity = transform.up * axis * moveSpeed * Time.deltaTime;
    }

    public void Rotate(float axis)
    {
        _rigidbody.rotation -= axis * rotateSpeed * Time.deltaTime;
    }
}