using UnityEngine;

public class CircleAttack : IAttackStrategy
{
    public void ExecuteAttack(Transform spawnPoint)
    {
        int bulletCount = 8;    // 한번에 발사되는 총알 개수
        float spreadAngle = 360f / bulletCount; // 발사각 조정 (플레이어 중심으로 원형으로 퍼짐)
        spawnPoint.position =  new Vector3(0, 1, 0);    // 플레이어 중심에서 발사하도록 위치 조정

        for (int i = 0; i < bulletCount; i++)
        {
            float angle = spreadAngle * i;
            Quaternion rotation = Quaternion.Euler(0, angle, 0);
            
            GameObject bullet = GameObject.Instantiate(Resources.Load("CircleBullet"), spawnPoint) as GameObject;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            // spawnPoint 기준 앞으로 10f만큼 이동
            // Use Gravity false 이므로 중력 없이 직선으로 발사
            // IsTrigger true로 설정하여 플레이어가 collider 있어도 플레이어 중심으로 원형 공격 가능
            rb.velocity = rotation * Vector3.forward * 10f;
            
        }
        
        spawnPoint.position =  new Vector3(0, 1, 1);    // 조정한 발사 위치 복구
    }
}