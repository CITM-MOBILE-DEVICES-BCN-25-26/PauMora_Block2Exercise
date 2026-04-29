using System;

public class RewardSystem
{
    public interface IRewardable 
    {
        public void GiveReward();
    }

    public void GiveReward(IRewardable rewardType)
    {
        rewardType.GiveReward(); 
    }

    public class Coins : IRewardable
    {
        public void GiveReward()
        {
            Console.WriteLine("Giving coins");
        }
    }

    public class Item : IRewardable 
    {
        public void GiveReward()
        {
            Console.WriteLine("Giving item");
        }
    }

    public class Unlockable : IRewardable 
    {
        public void GiveReward()
        {
            Console.WriteLine("Unlocking content");
        }
    }

}
