using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackStrategy
{
    void ExecuteAttack(Transform spawnPoint);
}
public interface ISkill
{
    void ExecuteSkill();
}
public class Player : MonoBehaviour
{
    private IAttackStrategy _currentAttack;   // 현재 사용 중인 공격 패턴
    [SerializeField] private Transform attackSpawnPoint;

    public void SetAttackStrategy(IAttackStrategy strategy)
    {
        _currentAttack = strategy;
    }

    public void Attack()
    {
        _currentAttack?.ExecuteAttack(attackSpawnPoint);
    }
}


