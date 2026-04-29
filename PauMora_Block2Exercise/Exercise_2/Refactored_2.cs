public class SkillSystem
{
    public int ApplySkill(Skill skillType, int baseDamage)
    {
        return skillType.CalculateDamage(baseDamage);
    }

    public interface Skill 
    {
        public int CalculateDamage(int baseDamage);
    }

    public class Fire : Skill
    {
        public int CalculateDamage(int baseDamage)
        {
            return baseDamage + 10;
        }
    }
    public class Ice : Skill
    {
        public int CalculateDamage(int baseDamage)
        {
            return baseDamage + 5;
        }
    }
    public class Poison : Skill
    {
        public int CalculateDamage(int baseDamage)
        {
            return baseDamage + 2;
        }
    }


}
