using UnityEngine;

public class FollowPath : MonoBehaviour
{

    // Array of waypoints to walk from one to the next one
    [SerializeField]
    private Transform[] waypoints;

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;

    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;

    public Rigidbody2D rb;

    public Animator animator;

    public Vector3 pivot;

    // Use this for initialization
    private void Start()
    {
        pivot = new Vector3(0.0f, 1.0f, 0.0f);
        // Set position of Enemy as position of the first waypoint
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    private void Update()
    {

        // Move Enemy
        Move();

    }

    // Method that actually make Enemy walk
    private void Move()
    {
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointIndex <= waypoints.Length - 1)
        {

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position+ pivot,
               moveSpeed * Time.deltaTime);

            animator.SetFloat("Horizontal", transform.position.x);
            animator.SetFloat("Vertical", transform.position.y);
            animator.SetFloat("Speed", moveSpeed);

            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint
            if (transform.position == waypoints[waypointIndex].transform.position+pivot)
            {
                waypointIndex += 1;
                if(waypointIndex == waypoints.Length)
                {
                    waypointIndex = 0;
                }
            }

           
        }
    }
}
