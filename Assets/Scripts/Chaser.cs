using UnityEngine;

public class Chaser : MonoBehaviour
{
    private Movement _movement;

    private Transform _player;

    private void Start()
    {
        _movement = GetComponent<Movement>();
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        ChasePlayer();
    }

    private void ChasePlayer()
    {
        float angle = Angle(transform.up, _player.position - transform.position);

        if (angle > 0.1f)
        {
            _movement.Rotate(-1);
        }
        else if (angle < -0.1f)
        {
            _movement.Rotate(1);
        }

        _movement.MoveForward(1);
    }

    private float Angle(Vector2 vec1, Vector2 vec2)
    {
        Vector2 vec1Rotated90 = new Vector2(-vec1.y, vec1.x);
        float sign = (Vector2.Dot(vec1Rotated90, vec2) < 0) ? -1.0f : 1.0f;
        return Vector2.Angle(vec1, vec2) * sign;
    }
}