using UnityEngine;

public enum Skills
{
    Radiation,
    Healing,
}
public class QuickSlotManager : SingletonBase<QuickSlotManager>
{
    [SerializeField] private QuickSlot[] quickSlots;
    
    private void Start()
    {
        // 퀵슬롯 초기화
        quickSlots = new QuickSlot[2];
        for (int i = 0; i < quickSlots.Length; i++)
        {
            quickSlots[i] = gameObject.AddComponent<QuickSlot>();
        }
        
        EuquipSkillToSlot((int)Skills.Radiation, new Radiation());
        EuquipSkillToSlot((int)Skills.Healing, new HealingFactor());
    }

    private void EuquipSkillToSlot(int idx, ISkill skill)
    {
        if (idx < quickSlots.Length)
        {
            quickSlots[idx].EquipSkill(skill);
        }
    }
    
    public void UseSkillInSlot(int idx)
    {
        if (idx < quickSlots.Length)
        {
            quickSlots[idx].UseSkill();
        }
    }
}
