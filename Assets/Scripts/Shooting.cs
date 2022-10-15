using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float _frontTimer;
    private float _leftTimer;
    private float _rightTimer;

    public Transform frontCannon;
    public Transform[] leftCannons;
    public Transform[] rightCannons;

    public Pool cannonBallPool;

    public float reloadTime;

    void Update()
    {
        _frontTimer += Time.deltaTime;
        _leftTimer += Time.deltaTime;
        _rightTimer += Time.deltaTime;
    }

    public void ShootForward()
    {
        if (_frontTimer < reloadTime)
        {
            return;
        }

        cannonBallPool.Spawn(frontCannon.position, frontCannon.rotation);

        _frontTimer = 0;
    }

    public void ShootLeft()
    {
        if (_leftTimer < reloadTime)
        {
            return;
        }

        foreach (var item in leftCannons)
        {
            cannonBallPool.Spawn(item.position, item.rotation);
        }

        _leftTimer = 0;
    }

    public void ShootRight()
    {
        if (_rightTimer < reloadTime)
        {
            return;
        }

        foreach (var item in rightCannons)
        {
            cannonBallPool.Spawn(item.position, item.rotation);
        }

        _rightTimer = 0;
    }

    public void ShootAll()
    {
        if (_frontTimer < reloadTime || _leftTimer < reloadTime || _rightTimer < reloadTime)
        {
            return;
        }

        ShootForward();
        ShootLeft();
        ShootRight();
    }
}