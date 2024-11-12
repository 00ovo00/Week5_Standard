using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Player playerattack;
    
    private void Start()
    {
        //playerattack.SetAttackStrategy(new StraightAttack());
    }
    
    public void OnStraight(InputAction.CallbackContext context)
    {
        playerattack.SetAttackStrategy(new StraightAttack());
        playerattack.Attack();
    }
    public void OnArc(InputAction.CallbackContext context)
    {
        playerattack.SetAttackStrategy(new ArcAttack());
        playerattack.Attack();
    }
    public void OnCircle(InputAction.CallbackContext context)
    {
        playerattack.SetAttackStrategy(new CircleAttack());
        playerattack.Attack();
    }
}
