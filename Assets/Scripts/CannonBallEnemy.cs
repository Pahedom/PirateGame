using UnityEngine;

public class CannonBallEnemy : CannonBall
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerHitbox"))
        {
            collision.gameObject.GetComponentInParent<Health>().TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}