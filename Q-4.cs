
public abstract class GameObject
{
    // Common method for updating game objects each frame
    public abstract void Update();
}
// Game object classes inherit from the abstract class
public class Player : GameObject
{
    public override void Update()
    {
        // Implement player-specific update logic here
    }
}
public class Enemy : GameObject
{
    public override void Update()
    {
        // Implement enemy-specific update logic here
    }
}