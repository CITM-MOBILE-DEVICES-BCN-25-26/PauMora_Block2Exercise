using System;

public class RewardSystem
{
    public void GiveReward(IRewardable rewardType)
    {
        rewardType.GiveReward();
    }
}

public interface IRewardable
{
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