using System;

public class GameEntity
{
  
}

public interface IMovable
{
    public void Move();
}

public class Player : GameEntity, IMovable
{
    public void Move()
    {
        Console.WriteLine("Player moving");
    }
}

public class Wall : GameEntity
{
    
}

public class MovementSystem
{
    public void MoveEntity(IMovable entity)
    {
        entity.Move();
    }
}
