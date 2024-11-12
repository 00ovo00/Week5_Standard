using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleAttack : IAttackStrategy
{
    public void ExecuteAttack(Transform spawnPoint)
    {
        int bulletCount = 3;
        float spreadAngle = 360f / bulletCount;

        for (int i = 0; i < bulletCount; i++)
        {
            float angle = spreadAngle * i;
            Quaternion rotation = Quaternion.Euler(0, angle, 0);
            
            GameObject bullet = GameObject.Instantiate(Resources.Load("CircleBullet"), spawnPoint) as GameObject;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = rotation * Vector3.forward * 10f;
            
        }
    }
}