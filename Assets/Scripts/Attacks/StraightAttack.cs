using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightAttack : IAttackStrategy
{
    public void ExecuteAttack(Transform spawnPoint)
    {
        GameObject bullet = GameObject.Instantiate(Resources.Load("StraightBullet"), spawnPoint) as GameObject;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = spawnPoint.forward * 10f;
    }
}
