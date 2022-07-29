using UnityEngine;

public class WalkingAnimal : MonoBehaviour
{
    public float JumpVelocity = 1;

    public float MovementSpeed = 1;

    /// <summary>
    /// The amount of grip the animal has. 0 grip cannot climb vertical walls, 1 grip can hold its weight
    /// </summary>
    public float VerticalGrip = 1;

    public bool Grounded { get; private set; }

    /// <summary>
    /// 1 = Double jump, 0 = No double jump
    /// </summary>
    public int ExtraJumps = 1;

    // Update is called once per frame
    void Update()
    {
    }

    public void Jump( Vector2 direction )
    {

    }

    /// <summary>
    /// Moves the specified direction in world space.
    /// </summary>
    public void Move( Vector2 direction )
    {

    }
}