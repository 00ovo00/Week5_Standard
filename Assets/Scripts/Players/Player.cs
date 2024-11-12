using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackStrategy
{
    void ExecuteAttack(Transform spawnPoint);
}
public class Player : MonoBehaviour
{
    public IAttackStrategy currentAttack;
    [SerializeField] private Transform attackSpawnPoint;

    public void SetAttackStrategy(IAttackStrategy strategy)
    {
        currentAttack = strategy;
    }

    public void Attack()
    {
        currentAttack?.ExecuteAttack(attackSpawnPoint);
    }
}


