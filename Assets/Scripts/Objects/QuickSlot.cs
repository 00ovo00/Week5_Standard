using UnityEngine;

public class QuickSlot : MonoBehaviour
{
    private ISkill _currentSkill;   // 현재 사용 중인 스킬

    public void EquipSkill(ISkill skill)
    {
        _currentSkill = skill;
    }

    public void UseSkill()
    {
        _currentSkill?.ExecuteSkill();
    }
}
