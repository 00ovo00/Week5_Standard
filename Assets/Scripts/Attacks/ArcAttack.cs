using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcAttack : IAttackStrategy
{
    public void ExecuteAttack(Transform spawnPoint)
    {
        GameObject bullet = GameObject.Instantiate(Resources.Load("ArcBullet"), spawnPoint) as GameObject;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, 20f, spawnPoint.position.z * 10f);
    }
}