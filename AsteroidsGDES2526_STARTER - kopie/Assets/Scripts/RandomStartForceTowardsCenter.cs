using UnityEngine;

//Rosa's
[RequireComponent(typeof(Rigidbody))]
public class RandomStartForceTowardsCenter : MonoBehaviour
{
    public float minForceMagnitude;
    public float maxForceMagnitude;

    private void Start()
    {
        Vector3 direction = -transform.position.normalized;

        float forceMagnitude = Random.Range(minForceMagnitude, maxForceMagnitude);

        GetComponent<Rigidbody>().AddForce(direction * forceMagnitude, ForceMode.VelocityChange);
    }
}
