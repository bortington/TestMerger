using UnityEngine;

/// <summary>
/// Keeps the character anchored to vertical walls and ceilings
/// </summary>
public class Gripper : MonoBehaviour
{
    public Vector2 RaycastDirection = Vector2.down;

    /// <summary>
    /// Called when draw gizmos selected occurs.
    /// </summary>
    private void OnDrawGizmosSelected()
    {

    }
}