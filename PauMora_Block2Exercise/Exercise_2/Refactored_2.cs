public class SkillSystem
{
    public int ApplySkill(ISkill skillType, int baseDamage)
    {
        return skillType.CalculateDamage(baseDamage);
    }
}

public interface ISkill 
{
    public int CalculateDamage(int baseDamage);
}

public class Fire : ISkill
{
    public int CalculateDamage(int baseDamage)
    {
        return baseDamage + 10;
    }
}
public class Ice : ISkill
{
    public int CalculateDamage(int baseDamage)
    {
        return baseDamage + 5;
    }
}
public class Poison : ISkill
{
    public int CalculateDamage(int baseDamage)
    {
        return baseDamage + 2;
    }
}