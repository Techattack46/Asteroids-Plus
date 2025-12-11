using UnityEngine;

public class ScreenEdgeTeleport : MonoBehaviour
{
    public float horizontalEdge;
    public float verticalEdge;

    private void Update()
    {
        if (transform.position.x < -horizontalEdge)
        {
            transform.position = new Vector3(horizontalEdge, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > horizontalEdge)
        {
            transform.position = new Vector3(-horizontalEdge, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -verticalEdge)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, verticalEdge);
        }

        if (transform.position.z > verticalEdge)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -verticalEdge);
        }
    }
}
