using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowThePath : MonoBehaviour
{
    [SerializeField]
    public Transform[] waypoints1;

    [SerializeField]
    public Transform[] waypoints2;

    [SerializeField]
    public Transform[] waypoints3;

    [SerializeField]
    public Transform[] waypoints4;

    [SerializeField]
    public Transform endwaypoints1;

    [SerializeField]
    public Transform endwaypoints2;

    [SerializeField]
    public Transform endwaypoints3;

    [SerializeField]
    public Transform endwaypoints4;
    
    [SerializeField]
    private float moveSpeed = 100f;

    private Transform[] currentWaypoints;
    private int waypointIndex = 0;
    private bool isMoving = false;

    public string nextScene1 = "SceneMovement";
    public string nextScene2;
    public string nextScene3;
    public string nextScene4;

    private void Start()
    {
        currentWaypoints = waypoints1;
        if (currentWaypoints.Length > 0)
        {
            transform.position = currentWaypoints[waypointIndex].position;
        }
        else
        {
            Debug.LogWarning("No waypoints assigned to FollowThePath script!");
        }
    }

    public void StartMoving()
    {
        if (currentWaypoints.Length > 0)
        {
            isMoving = true;
        }
        else
        {
            Debug.LogWarning("No waypoints assigned to FollowThePath script!");
        }
    }

    private void Update()
    {
        if (isMoving)
        {
            Move();
        }
    }

    private void Move()
    {
        if (waypointIndex < currentWaypoints.Length)
        {
            Vector3 targetPosition = currentWaypoints[waypointIndex].position;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }
        }
        else
        {
            isMoving = false;
            Debug.Log("Reached the end of the path!");
            Debug.Log(currentWaypoints[waypointIndex-1].position == endwaypoints1.position);

            // Sprite telah mencapai ujung path, ganti scene sesuai dengan path
            if (currentWaypoints[waypointIndex-1].position==endwaypoints1.position)
            {
                SceneManager.LoadScene(nextScene1);
            }
            else if (currentWaypoints[waypointIndex - 1].position == endwaypoints2.position)
            {
                SceneManager.LoadScene(nextScene2);
            }
            else if (currentWaypoints[waypointIndex - 1].position == endwaypoints3.position)
            {
                SceneManager.LoadScene(nextScene3);
            }
            else if (currentWaypoints[waypointIndex - 1].position == endwaypoints4.position)
            {
                SceneManager.LoadScene(nextScene4);
            }
        }
    }

    public void SetCurrentWaypoints(Transform[] waypoints)
    {
        currentWaypoints = waypoints;
        waypointIndex = 0;
    }
}
