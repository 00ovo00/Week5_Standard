using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackStrategy
{
    void ExecuteAttack(Transform spawnPoint);
}
public class Player : MonoBehaviour
{
    public IAttackStrategy CurrentAttack;   // 현재 사용 중인 공격 패턴
    [SerializeField] private Transform attackSpawnPoint;

    public void SetAttackStrategy(IAttackStrategy strategy)
    {
        CurrentAttack = strategy;
    }

    public void Attack()
    {
        CurrentAttack?.ExecuteAttack(attackSpawnPoint);
    }
}


