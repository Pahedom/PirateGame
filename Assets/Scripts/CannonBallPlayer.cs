using UnityEngine;

public class CannonBallPlayer : CannonBall
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyHitbox"))
        {
            collision.gameObject.GetComponentInParent<Health>().TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}