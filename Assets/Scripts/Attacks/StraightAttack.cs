using UnityEngine;

public class StraightAttack : IAttackStrategy
{
    public void ExecuteAttack(Transform spawnPoint)
    {
        GameObject bullet = GameObject.Instantiate(Resources.Load("StraightBullet"), spawnPoint) as GameObject;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        // spawnPoint 기준 앞으로 10f만큼 이동
        // Use Gravity false 이므로 중력 없이 직선으로 발사
        rb.velocity = spawnPoint.forward * 10f;
    }
}
