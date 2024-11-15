using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Player playerattack;
    
    public void OnStraight(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)    // Z 키
        {
            playerattack.SetAttackStrategy(new StraightAttack());
            playerattack.Attack();
        }
    }
    
    public void OnArc(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)    // X 키
        {
            playerattack.SetAttackStrategy(new ArcAttack());
            playerattack.Attack();
        }
    }
    
    public void OnCircle(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)    // C 키
        {
            playerattack.SetAttackStrategy(new CircleAttack());
            playerattack.Attack();
        }
    }
    
    public void OnRadiation(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)    // Q 키
        {
            QuickSlotManager.Instance.UseSkillInSlot((int)Skills.Radiation);
        }
    }
    
    public void OnHeal(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)    // W 키
        {
            QuickSlotManager.Instance.UseSkillInSlot((int)Skills.Healing);
        }
    }
}
