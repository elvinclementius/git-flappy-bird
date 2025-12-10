using UnityEngine;

// 1. INHERITANCE
public class PipeController : ObstacleBase
{
    // 2. POLYMORPHISM
    public override void Move()
    {
    
        Vector3 newPosition = transform.position;
        newPosition.x -= speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
