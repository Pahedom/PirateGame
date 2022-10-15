using UnityEngine;

public class CannonBall : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody;

    public float damage;

    public float speed;

    private void Update()
    {
        _rigidbody.velocity = transform.up * speed;
    }
}