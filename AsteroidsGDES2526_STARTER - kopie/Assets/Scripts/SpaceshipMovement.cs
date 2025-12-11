using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    public Rigidbody player;
    public float rotationSpeed;
    public float movementSpeed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0,rotationSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0,-rotationSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            player.AddRelativeForce(movementSpeed * Time.deltaTime * Vector3.forward);
        }
    }
}
