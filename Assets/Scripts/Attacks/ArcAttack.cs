using UnityEngine;

public class ArcAttack : IAttackStrategy
{
    public void ExecuteAttack(Transform spawnPoint)
    {
        GameObject bullet = GameObject.Instantiate(Resources.Load("ArcBullet"), spawnPoint) as GameObject;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        // 위로 20, spawnPoint 기준 앞으로 10f만큼 이동
        // Use Gravity true 이므로 중력에 의해 포물선을 그리며 발사
        rb.velocity = new Vector3(0f, 20f, spawnPoint.position.z * 10f);
    }
}