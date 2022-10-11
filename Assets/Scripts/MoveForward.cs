using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody;

    public float speed;

    private void Update()
    {
        _rigidbody.velocity = transform.up * speed * Time.deltaTime;
    }
}