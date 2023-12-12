using UnityEngine;

public class SpriteClickHandler : MonoBehaviour
{
    public FollowThePath pathFollower;
    public Transform[] waypoints;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        // Set sprite dan path aktif pada FollowThePath
       //pathFollower.SetActiveSprite(spriteRenderer);
        pathFollower.SetCurrentWaypoints(waypoints);
        pathFollower.StartMoving();
    }
}