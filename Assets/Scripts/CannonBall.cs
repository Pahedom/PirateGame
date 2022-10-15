using UnityEngine;

public class CannonBall : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody;

    [SerializeField]
    private PoolObject _poolObject;

    public float damage;

    public float speed;

    public string targetTag;

    private void Update()
    {
        _rigidbody.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            collision.gameObject.GetComponentInParent<Health>().TakeDamage(damage);

            _poolObject.Dispawn();
        }
    }
}