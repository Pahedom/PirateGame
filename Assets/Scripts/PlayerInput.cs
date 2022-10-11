using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Movement movement;
    public Shooting shooting;

    void Update()
    {
        Move();
        Rotate();

        ShootForward();
        ShootLeft();
        ShootRight();
        ShootAll();
    }

    private void Move()
    {
        movement.MoveForward(Input.GetAxis("Vertical"));
    }

    private void Rotate()
    {
        movement.Rotate(Input.GetAxis("Horizontal"));
    }

    private void ShootForward()
    {
        if (Input.GetButton("ShootForward"))
        {
            shooting.ShootForward();
        }
    }

    private void ShootLeft()
    {
        if (Input.GetButton("ShootLeft"))
        {
            shooting.ShootLeft();
        }
    }

    private void ShootRight()
    {
        if (Input.GetButton("ShootRight"))
        {
            shooting.ShootRight();
        }
    }

    private void ShootAll()
    {
        if (Input.GetButton("ShootAll"))
        {
            shooting.ShootAll();
        }
    }
}